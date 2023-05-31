function initializeTable() {
    $('#createLink').on('click', prepareData);

    let firstObj = {
        Bulgaria: 'Sofia',
        Germany: 'Berlin',
        Russia: 'Moscow'
    }

    Object.keys(firstObj).forEach(country => {
        insertCountry(country, firstObj[country]);
    })

    function prepareData() {
        let country = $('#newCountryText').val();
        let capital = $('#newCapitalText').val();
        insertCountry(country, capital);
        $('#newCountryText').val('');
        $('#newCapitalText').val('');
    }

    function insertCountry(countryName, capitalName) {
        let row = $('<tr>').append($('<td>').text(countryName))
            .append($('<td>').text(capitalName))
            .append(
                $('<td>')
                    .append($('<a href="#">[Up]</a>').on('click', moveUp))
                    .append($('<a href="#">[Down]</a>').on('click', moveDown))
                    .append($('<a href="#">[Delete]</a>').on('click', deleteRow))
            );
        $('#countriesTable').append(row);
        fixLinks();
    }

    function moveUp() {
        let row = $(this).parent().parent();
        row.insertBefore(row.prev());
        fixLinks();
    }
    function moveDown() {
        let row = $(this).parent().parent();
        row.insertAfter(row.next());
        fixLinks();
    }
    function deleteRow() {
        let row = $(this).parent().parent();
        row.remove();
        fixLinks();
    }

    function fixLinks(){
        let table = $('tr');
        table.find('a').css('display', 'inline');

        $(table[2]).find('a:contains("Up")').css('display', 'none');
        $(table[table.length - 1]).find('a:contains("Down")').css('display', 'none');
    }
}
