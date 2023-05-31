function domSearch($selector, bool) {

    let $resultControlUL = $('<ul>')
        .addClass('items-list');
    let $resultControlContainer = $('<div>')
        .addClass('result-controls ')
        .append($resultControlUL);

    let $addControlLabel = $('<label>')
        .text('Enter text:');
    let $addControlInput = $('<input>');
    $addControlLabel.append($addControlInput);
    let $addControlAnchor = $('<a>')
        .text('Add')
        .addClass('button')
        .css('display', 'inline-block');
    let $addControlContainer = $('<div>')
        .addClass('add-controls')
        .append($addControlLabel)
        .append($addControlAnchor);

    let $searchControlLabel = $('<label>')
        .text('Search:');
    let $searchControlInput = $('<input>');
    $searchControlLabel.append($searchControlInput);
    let $searchControlContainer = $('<div>')
        .addClass('search-controls')
        .append($searchControlLabel);

    let $content = $($selector)
        .addClass('items-control')
        .append($addControlContainer)
        .append($searchControlContainer)
        .append($resultControlContainer);

    let $addButtonEvent = $addControlAnchor.on('click', (evt) => {
        evt.preventDefault();
        let $inputStr = $addControlInput.val();
        let $liItemText = $('<strong>')
            .text(`${$inputStr}`);
        let $liItemButton = $('<a>')
            .text('X')
            .addClass('button');
        let $liItemContainer = $('<li>')
            .addClass('list-item')
            .append($liItemButton)
            .append($liItemText);
        $resultControlUL
            .append($liItemContainer);

        $addControlInput.val('');

        $liItemButton.on('click', (evt) => {
            evt.preventDefault();
            $(evt.target).parent().remove();
        });
    });

    let $searchEvent = $searchControlInput
        .on('input', () => {
            let $searchString;
            if (bool) {
                $searchString = $searchControlInput.val();
            } else {
                $searchString = $searchControlInput.val().toLowerCase();
            }

            if ($searchString.length > 0) {
                for (let i = 0; i < $resultControlUL.children().length; i++) {
                    let elem = $resultControlUL.children().eq(i).text();
                    if (!bool){
                        elem = elem.toLowerCase();
                    }
                    if (elem.substring(1).indexOf($searchString) < 0) {
                        $resultControlUL.children().eq(i).css('display', 'none');
                    }
                }
            } else {
                $resultControlUL.children().removeAttr('style');
            }
        });
}