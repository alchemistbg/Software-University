function solve(secretDate) {
    let nameRegex = /\*[A-Z][A-Za-z]*(?=\s|$)/g;
    let phoneRegex = /\+[0-9-]{10}(?=\s|$)/g;
    let idRegex = /![a-zA-Z0-9]+(?=\s|$)/g;
    let baseRegex = /_[0-9A-Za-z]+(?=\s|$)/g;

    for (let line of secretDate) {
        console.log(
            line
            .replace(nameRegex, x => '|'.repeat(x.length))
            .replace(phoneRegex, x => '|'.repeat(x.length))
            .replace(idRegex, x => '|'.repeat(x.length))
            .replace(baseRegex, x => '|'.repeat(x.length))
        );
    }
}

function solve(n) {
    let cleanData = n.join('\n')
        .replace(/(\*[A-Z][A-Za-z]*|_[A-Za-z\d]+|![a-zA-Z\d]+|\+[\d-]{10})(?= |\t|$)/gm,
                b => "|".repeat(b.length));
    return cleanData;
}

console.log(solve(
    ['Agent *Ivankov was in the room when it all happened +555-555-55.',
        'The person in the room was heavily armed.',
        'Agent *Ivankov had to act quick in order.',
        'He picked up his phone and called some unknown number.',
        'I think it was +555-49-796',
        'I can\'t really remember...',
        'He said something about "finishing work" with subject !2491a23BVB34Q and returning to Base _Aurora21',
        'Then after that he disappeared from my sight.',
        'As if he vanished in the shadows.',
        'A moment, shorter than a second, later, I saw the person flying off the top floor.',
        'I really don\'t know what happened there.',
        'This is all I saw, that night.',
        'I cannot explain it myself...']
));