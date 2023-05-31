function validate() {

    //let isValid = false;
    let isCompanyChecked;
    $('#company').on('change', () => {
        isCompanyChecked = $('#company').prop('checked');
        if ($('#company').prop('checked')) {
            $('#companyInfo').css('display', 'block');
        }else {
            $('#companyInfo').css('display', 'none');
        }
    });

    $('#submit').on('click', (evt) => {
        evt.preventDefault();
        evt.stopPropagation();

        let $uName = $('#username').val();
        validateUserName($uName);
        let $eMail = $('#email').val();
        validateEmail($eMail);
        let $pWord1 = $('#password').val();
        let $pWord2 = $('#confirm-password').val();
        validatePassword($pWord1, $pWord2);
        if (isCompanyChecked){
            let $cNumber = $('#companyNumber').val();
            validateCompanyNumber($cNumber);
        }

        isFormValid();
    });

    function validateUserName($uName){
        let regex = /^[A-Za-z\d]{3,20}$/;
        if (!regex.test($uName)){
            $('#username').css('border-color', 'red');
        }
    }

    function validateEmail($eMail){
        // Both regex patterns work!
        //let regex = /^.+@.*\.+.*$/;
        let regex = /^\S+@\S*\.\S*$/;
        if (!regex.test($eMail)){
            $('#email').css('border-color', 'red');
        }
    }

    function validatePassword($p1, $p2){
        let regex = /^\w{5,15}$/;
        if ($p1 !== $p2 || !regex.test($p1)){
            $('#password').css('border-color', 'red');
            $('#confirm-password').css('border-color', 'red');
        }
    }

    function validateCompanyNumber($cNumber) {
        let regex = /^[1-9][0-9]{3}$/g;
        if(!regex.test($cNumber)){
            $('#companyNumber').css('border-color', 'red');
        }
    }

    function isFormValid() {
        if ($('[style*="border-color: red"]').length === 0){
            $('#valid').css('display', 'block');
        }
    }
}
