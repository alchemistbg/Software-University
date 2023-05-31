function realEstateAgency () {
	// TODO...
    $('[name="regOffer"]').on('click', () => {
        let rent = +$('[name="apartmentRent"]').val();
        let type = $('[name="apartmentType"]').val();
        let comm = +$('[name="agencyCommission"]').val();

        if (typeof rent === 'number' && rent > 0 &&
            typeof comm === 'number' && (comm >= 0) && (comm <= 100) &&
            /^[^:]+$/.test(type)){
            $('#message').text('Your offer was created successfully.');

            let div = $('<div>').addClass('apartment')
                .append(`<p>Rent: ${rent}</p>`)
                .append(`<p>Type: ${type}</p>`)
                .append(`<p>Commission: ${comm}</p>`);
            $('#building').append(div);
        }else{
            $('#message').text('Your offer registration went wrong, try again.');
        }

        $('[name="apartmentRent"]').val('');
        $('[name="apartmentType"]').val('');
        $('[name="agencyCommission"]').val('');
    });

    $('[name="findOffer"]').on('click', () => {
        let budget = +$('[name="familyBudget"]').val();
        let type = $('[name="familyApartmentType"]').val();
        let name = $('[name="familyName"]').val();

        if (typeof budget === 'number' && budget > 0 && typeof type ==='string' && type.length > 0 &&
            typeof name === 'string' && name.length > 0){
            let matchedApp;
            let apps = $('.apartment');
            for (let i = 0; i < apps.length; i++) {
                let currRent = +apps[i].childNodes[0].innerText.split(': ')[1];
                let currType = apps[i].childNodes[1].innerText.split(': ')[1];
                let currCom = +apps[i].childNodes[2].innerText.split(': ')[1];
                if (type === currType && budget >= currRent + (currRent*currCom/100)){

                    apps[i].childNodes[0].innerText = name;
                    apps[i].childNodes[1].innerText = 'live here now';
                    apps[i].childNodes[2].remove(2);
                    let moveBtn = $('<button>').text('MoveOut').appendTo(apps[i]);

                    apps[i].setAttribute('style', 'border: 2px solid red;');
                    $('#message').text('Enjoy your new home! :))');

                    let agCurrProfit = +$('#roof').text().split(': ')[1].split(' ')[0];
                    agCurrProfit += (currRent*currCom/100)*2;

                    $('#roof h1').text(`Agency profit: ${agCurrProfit} lv.`);
                    moveBtn.on('click', (evt) => {
                        evt.target.parentNode.remove();
                        $('#message').text(`They had found cockroaches in ${name}'s apartment`);
                    });

                    break;
                }
            }
           //console.log($('.apartment')[matchedApp])
        }else{
            $('#message').text('We were unable to find you a home, so sorry :(');
        }
    });
}