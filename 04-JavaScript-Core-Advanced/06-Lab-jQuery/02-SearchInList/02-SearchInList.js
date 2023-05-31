function search() {

    const qText = $('#searchText').val().toLowerCase();
    const listItems = $('#towns li')
        .css('font-weight', '')
        .filter((index, elem) => {
            return elem.textContent.toLowerCase().indexOf(qText) > -1;
        }).css('font-weight', 'bold');
    $('#result').text(`${listItems.length} matches found.`);

    //Solution sent to judge - 100/100
    // const qText = $('#searchText').val();
    // const listItems = $(`#towns li:contains('${qText}')`);
    //
    // listItems.css('font-weight', 'bold');
    //
    // $('#result').text(`${listItems.length} matches found.`);
}