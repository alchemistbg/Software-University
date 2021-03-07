function solve(input) {
    let data = input.map(x => JSON.parse(x));
    let cities = {};
    for (let entry of data) {
        if (cities[entry.town] === undefined){
            cities[entry.town] = 0;
        }
        cities[entry.town] += entry.income;
    }

    let citiesNames = Object.keys(cities).sort();
    for (let city of citiesNames) {
        console.log(`${city} -> ${cities[city]}`);
    }
}

solve([
    '{"town":"Sofia","income":200}',
    '{"town":"Varna","income":120}',
    '{"town":"Pleven","income":60}',
    '{"town":"Varna","income":70}'
]);*/
