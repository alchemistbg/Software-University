function increment(s) {
    let $selector = $(s);

    let $ul = $('<ul>');
    $ul.addClass('results');

    let $tArea = $('<textarea>');
    $tArea.text('0');
    $tArea.attr('value', '0');
    $tArea.attr('disabled', 'true');
    $tArea.addClass('counter');

    let $incrementBtn = $('<button>');
    $incrementBtn.addClass('btn');
    $incrementBtn.attr('id', 'incrementBtn');
    $incrementBtn.text('Increment');
    $incrementBtn.on('click', (e) => {
        let $taValue = +$tArea.text();
        $taValue++;
        $tArea.text($taValue);
    });

    let $addBtn = $('<button>');
    $addBtn.addClass('btn');
    $addBtn.attr('id', 'addBtn');
    $addBtn.text('Add');
    $addBtn.on('click', (e) => {
        let $taValue = $tArea.text();
        $li = $('<li>');
        $li.text($taValue);
        $ul.append($li);
    });

    $selector.append($tArea);
    $selector.append($incrementBtn);
    $selector.append($addBtn);
    $selector.append($ul);
}