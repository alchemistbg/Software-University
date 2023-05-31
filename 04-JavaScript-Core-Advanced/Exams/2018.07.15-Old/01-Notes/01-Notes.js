function addSticker() {
    let $noteTitle = $('.title').val();
    let $noteContent = $('.content').val();

    if ($noteTitle && $noteContent){
        $('.title').val('');
        $('.content').val('');

        let $note = $('<li>').addClass('note-content');

        let $closeButton = $('<a>').addClass('button').text('x').appendTo($note);
        let $noteHeader = $('<h2>').text($noteTitle).appendTo($note);
        $note.append('<hr>');
        let $noteBody = $('<p>').text($noteContent).appendTo($note);

        $('#sticker-list').append($note);

        $closeButton.on('click', (evt) => {
            evt.preventDefault();
            evt.target.parentNode.remove();
        });
    }
}