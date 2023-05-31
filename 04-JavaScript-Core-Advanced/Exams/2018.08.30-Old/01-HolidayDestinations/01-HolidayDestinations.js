function addDestination() {

    let $city = $('.inputData').eq(0).val();
    let $country = $('.inputData').eq(1).val();
    //some basic data validation
    if ($city.length === 0 || $country.length === 0){
        return;
    }
    //old
    //let $season = $('#seasons').val()[0].toUpperCase() + $('#seasons').val().substring(1);
    let $season = $('#seasons option:selected').html();

    $('.inputData').eq(0).val('');
    $('.inputData').eq(1).val('');
    $('#seasons').val('summer');

    let $destinationCell = $('<td>')
        .text(`${$city}, ${$country}`);
    let $seasonCell = $('<td>')
        .text(`${$season}`);
    let $tableRow = $('<tr>')
        .append($destinationCell)
        .append($seasonCell);
    $('#destinationsList').append($tableRow);

    switch ($season) {
        case 'Summer':
            let $summerValue = +$('#summer').val();
            $summerValue += 1;
            $('#summer').val($summerValue);
            break;
        case 'Autumn':
            let $autumnValue = +$('#autumn').val();
            $autumnValue += 1;
            $('#autumn').val($autumnValue);
            break;
        case 'Winter':
            let $winterValue = +$('#winter').val();
            $winterValue += 1;
            $('#winter').val($winterValue);
            break;
        case 'Spring':
            let $springValue = +$('#spring').val();
            $springValue += 1;
            $('#spring').val($springValue);
            break;
    }
}