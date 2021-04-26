function solve(input) {
    let digits = [];
    let matches = input
        .map(x => x.match(/\d+/g))
        .filter(x => x !== null)
        .forEach(rowMatch => {
            let a = rowMatch;
            a.forEach(item => digits.push(item));
        });
    return digits.join(' ')
}

console.log(solve([
    'The300',
    'What is that?',
    'I think it’s the 3rd movie.',
    'Lets watch it at 22:45'
]));