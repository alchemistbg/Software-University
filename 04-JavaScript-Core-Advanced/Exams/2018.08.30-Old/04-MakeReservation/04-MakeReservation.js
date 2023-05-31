function makeReservation($container) {

    let $name;
    let $email;
    let $phoneNumber;
    let $address;
    let $postalCode;
    let $paymentHeader;
    let $paymentOptions;

    let $submitBtn = $('#submit');
    let $editBtn = $('#edit');
    let $continueBtn = $('#continue');

    $submitBtn.on('click', () => {

        $name = $('#fullName').val();
        $email = $('#email').val();
        $phoneNumber = $('#phoneNumber').val();
        $address = $('#address').val();
        $postalCode = $('#postalCode').val();

        if ($name.length > 0 && $email.length > 0) {
            $('#fullName').val('');
            $('#email').val('');
            $('#phoneNumber').val('');
            $('#address').val('');
            $('#postalCode').val('');

            $('#edit').prop('disabled', false);
            $('#continue').prop('disabled', false);
            $('#submit').prop('disabled', true);

            let $liName = $('<li>').text(`Name: ${$name}`).appendTo($('#infoPreview'));
            let $liEmail = $('<li>').text(`E-mail: ${$email}`).appendTo($('#infoPreview'));
            let $liphoneNumber = $('<li>').text(`Phone: ${$phoneNumber}`).appendTo($('#infoPreview'));
            let $liaddress = $('<li>').text(`Address: ${$address}`).appendTo($('#infoPreview'));
            let $lipostalCode = $('<li>').text(`Postal Code: ${$postalCode}`).appendTo($('#infoPreview'));
        }
    });

    $editBtn.on('click', () => {

        $('#fullName').val($name);
        $('#email').val($email);
        $('#phoneNumber').val($phoneNumber);
        $('#address').val($address);
        $('#postalCode').val($postalCode);

        $('ul li').remove();

        $('#edit').prop('disabled', true);
        $('#continue').prop('disabled', true);
        $('#submit').prop('disabled', false);
    });

    $continueBtn.on('click', () => {

        $('#edit').prop('disabled', true);
        $('#continue').prop('disabled', true);
        $('#submit').prop('disabled', true);

        let $paymentContainer = $($container);

        $paymentHeader = $('<h2>').text('Payment details');

        $paymentOptions = $('<select>').attr('id', 'paymentOptions').addClass('custom-select');
        let $option1 = $('<option selected>').text('Choose');
        $option1.prop('disabled', true).prop('hidden', true);
        let $option2 = $('<option>');
        $option2.attr('value', 'creditCard').text('Credit Card');
        let $option3 = $('<option>');
        $option3.attr('value', 'bankTransfer').text('Bank Transfer');
        $paymentOptions.append($option1).append($option2).append($option3);

        let $extraDetails = $('<div>').attr('id', 'extraDetails');

        $paymentContainer.append($paymentHeader).append($paymentOptions).append($extraDetails);

        let $selection;
        $('#paymentOptions').on('change', function() {
            $selection = $('#paymentOptions option:selected').val();

            let $checkOutBtn = $('<button>').attr('id', 'checkOut').text('Check Out');
            if ($selection ==='creditCard') {
                let $cardNumber = $('<div>').addClass('inputLabel').text('Card Number').append($('<input>'));
                let $expDate = $('<div>').addClass('inputLabel').text('Expiration Date').append($('<input>'));
                let $secNumbers = $('<div>').addClass('inputLabel').text('Security Numbers').append($('<input>'));
                $extraDetails.empty();
                $extraDetails.append($cardNumber).append($('<br>')).append($expDate).append($('<br>'))
                    .append($secNumbers).append($('<br>')).append($checkOutBtn);
            }else{
                $extraDetails.empty();
                $extraDetails.append($('<p>').html(`You have 48 hours to transfer the amount to:<br>IBAN: GR96 0810 0010 0000 0123 4567 890`)).append($checkOutBtn);
            }

            $checkOutBtn.on('click', () => {
                $('#wrapper').empty();
                $('#wrapper').append($('<h4>').text('Thank you for your reservation!'));
            });
        });
    });

}