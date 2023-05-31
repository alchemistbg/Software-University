function extractText(){
    let textA = $('li').toArray().map(x => x.textContent).join(', ');
    $('#result').text(textA);
}