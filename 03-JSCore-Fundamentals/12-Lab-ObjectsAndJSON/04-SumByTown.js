function solve(input) {
    let towns = {};
    for (let i = 0; i < input.length; i+=2) {
        let townsKeys = Object.keys(towns);
        let city = input[i];
        let number = +input[i+1];
        if (townsKeys.includes(city)){
            towns[city] += number;
        } else {
            towns[city] = number;
        }
    }
    console.log(JSON.stringify(towns))
}

solve([
    'Sofia',
    '20',
    'Varna',
    '3',
    'Sofia',
    '5',
    'Varna',
    '4'
]);