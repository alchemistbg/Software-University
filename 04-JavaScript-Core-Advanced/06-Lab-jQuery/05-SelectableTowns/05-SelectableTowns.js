function attachEvents() {

    let $towns = $('#items li').attr('data-selected', 'false').on('click', (e) => {
        let $town = $(e.target);
        if ($town.attr('data-selected') === 'false'){
            $town.attr('data-selected', 'true');
            $town.css('background-color', '#ddd');
        }else{
            $town.attr('data-selected', 'false');
            $town.css('background-color', '#fff');
        }
    });

    $('#showTownsButton').on('click', (e) => {
        let $selected = $('#items li[data-selected="true"]')
            .toArray()
            .map((x) => x.textContent)
            .join(', ');
        $('#selectedTowns').text(`Selected towns: ${$selected}`);
    });
}