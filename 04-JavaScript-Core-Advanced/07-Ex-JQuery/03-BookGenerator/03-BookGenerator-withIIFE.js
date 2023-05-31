let createBook = (function createBook() {
    let id = 1;
    return function ($selector, $bookTitle, $bookAuthor, $bookISBN) {
        //let $test = $('#wrapper').children().length;

        let fragment = document.createDocumentFragment();

        let bookContainer = $('<div>')
            .attr('id', `book${id++}`)
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
}());