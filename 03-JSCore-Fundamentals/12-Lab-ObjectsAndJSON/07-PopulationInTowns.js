function solve(input) {
    let cities = [];

    for (let inputLine of input) {
        let [cityName, cityPopulation] = inputLine.split(' <-> ');

        let indexCities = findWithAttr(cities, 'cName', cityName);
        if (indexCities > -1){
            cities[indexCities].cPop += +cityPopulation;
        } else{
            let city = {cName: cityName, cPop: +cityPopulation};
            cities.push(city);
        }
    }

    cities.forEach(
        x => console.log(`${x.cName} : ${x.cPop}`)
    );

    function findWithAttr(array, attr, value) {
        for(let i = 0; i < array.length; i += 1) {
            if(array[i][attr] === value) {
                return i;
            }
        }
        return -1;
    }
}

solve(
    [
        'Sofia <-> 1200000',
        'Montana <-> 20000',
        'New York <-> 10000000',
        'Washington <-> 2345000',
        'Las Vegas <-> 1000000'
    ]
);
console.log();
solve(
    [
        'Istanbul <-> 100000',
        'Honk Kong <-> 2100004',
        'Jerusalem <-> 2352344',
        'Mexico City <-> 23401925',
        'Istanbul <-> 1000'
    ]
);
