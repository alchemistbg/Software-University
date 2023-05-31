function createBook($selector, $bookTitle, $bookAuthor, $bookISBN) {
    let id;
    let wrapperChildNumber = $('#wrapper').children().length;
    if (wrapperChildNumber === null){
        id = 1;
    } else {
        id = wrapperChildNumber + 1;
    }

    let fragment = document.createDocumentFragment();

    let bookContainer = $('<div>')
        .attr('id', `book${id}`)
        .css('border', 'none');
    let bookTitle = $('<p>')
        .addClass('title')
        .text($bookTitle);
    let bookAuthor = $('<p>')
        .addClass('bookAuthor')
        .text($bookAuthor);
    let isbn = $('<p>')
        .addClass('isbn')
        .text($bookISBN);
    let selectBtn = $('<button>')
        .text('Select')
        .on('click', () => {
            bookContainer.css('border', '2px solid blue');
        });
    let deselectBtn = $('<button>')
        .text('Deselect')
        .on('click', () => {
            bookContainer.css('border', 'none');
        });

    bookContainer
        .append(bookTitle)
        .append(bookAuthor)
        .append(isbn)
        .append(selectBtn)
        .append(deselectBtn);

    bookContainer.appendTo(fragment);

    let container = $($selector);
    container.append(fragment);
}