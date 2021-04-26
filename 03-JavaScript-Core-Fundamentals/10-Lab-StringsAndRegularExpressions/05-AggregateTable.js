function solve(input) {
    let towns = [];
    let income = 0;

    for (let i = 0; i < input.length; i++) {
        let text = input[i].split('|').filter(x => x !== '');
        towns.push(text[0].trim());
        income += +text[1].trim();
    }
    console.log(towns.join(', '));
    console.log(income);
}

solve([
    '| Sofia           | 300',
    '| Veliko Tarnovo  | 500',
    '| Yambol          | 275'
]);