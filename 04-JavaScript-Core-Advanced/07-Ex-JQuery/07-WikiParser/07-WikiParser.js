function wikiParser($pSelector) {
    let $targetParagraphParent = $($pSelector).parent();
    let $newSelector = $pSelector.substring(1);

    let $targetParagraph = $($pSelector);
    $($pSelector).remove();

    let $newTargetParagraphContainer = $('<p>').attr('id', `${$newSelector}`);
    let $targetParagraphText = $targetParagraph.text()
        .split('\n')
        .filter((x) => {
            return x.length > 0;
        })
        .map((x) => {
            return x.trim();
        })
        .forEach((row) => {
            //console.log(row);
            let $new;
            if (/^=(\w+(\s*\w+)+)=$/.test(row)){
                let match = row.match(/^=(\w+(\s*\w+)+)=$/);
                $new = $('<h1>').html(match[1]);
            } else if (/^==(\w+(\s*\w+)+)==$/.test(row)) {
                let match = row.match(/^==(\w+(\s*\w+)+)==$/);
                $new = $('<h2>').html(match[1]);
            } else if (/^===(\w+(\s*\w+)+)===$/.test(row)) {
                let match = row.match(/^===(\w+(\s*\w+)+)===$/);
                $new = $('<h3>').html(match[1]);
            } else if (/'''(.*?)'''/.test(row)){
                let match = row.match(/'''(.+?)'''/);
                $new = $('<b>').html(match[1]);
                console.log(row);
            } else if (/''.*?''/g.test(row)){
                let match = row.match(/''(.+?)''/g);
                $new = $('<i>').html(match[1]);
            }
            $newTargetParagraphContainer.append($new);
        });

    $newTargetParagraphContainer.appendTo($targetParagraphParent);
}