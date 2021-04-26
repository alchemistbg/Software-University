function solve(input) {
    let countries = {};
    for (let iLine of input) {
        let iLineArr = iLine.split(' > ');
        let cName = iLineArr[0];
        let tName = iLineArr[1][0].toUpperCase() + iLineArr[1].slice(1);
        let tCost = +iLineArr[2];

        if (!countries.hasOwnProperty(cName)) {
            countries[cName] = {};
        }
        if (!countries[cName].hasOwnProperty(tName)) {
            countries[cName][tName] = tCost;
        } else {
            if (countries[cName][tName] > tCost) {
                countries[cName][tName] = tCost
            }
        }
    }
    console.log(countries)

    let sortedCountries = Object.keys(countries).sort((a, b) => a.localeCompare(b));

    let output = '';
    for (let country of sortedCountries) {
        output += `${country} -> `;

        let sortedTowns = Object.keys(countries[country])
            .sort((a, b) => countries[country][a] - countries[country][b]);
        for (let town of sortedTowns) {
            output += `${town} -> ${countries[country][town]} `;
        }
        output += '\n';
    }
    console.log(output);
}

solve([
    "Bulgaria > Sofia > 500",
    "Bulgaria > Sopot > 800",
    //"Bulgaria > sopot > 500", //added
    "France > Paris > 2000",
    "Albania > Tirana > 1000",
    "Bulgaria > Sofia > 200"
]);
console.log();
solve([
    'Bulgaria > Sofia > 25000',
    'aaa > Sofia > 1',
    'aa > Orgrimar > 0',
    'Albania > Tirana > 25000',
    'zz > Aarna > 25010',
    'Bulgaria > Lukovit > 10'
]);