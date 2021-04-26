function solve(input) {
    let cities = [];

    for (let inputLine of input) {
        let [city, product, sales] = inputLine.split(' -> ');
        let income = +sales.split(' : ')[0] * +sales.split(' : ')[1];

        let indexCity = findWithAttr(cities, 'cName', city);
        if (indexCity > -1){
            let indexProduct = findWithAttr(cities[indexCity], 'pName', product);
            if (indexProduct > -1){

            } else {
                let prodObj = {pName: product, pIncome: income};
                //console.log(prodObj)
                cities[indexCity].sales.push(prodObj);
            }
        } else {
            let cityObj = {
                cName: city, sales: [
                    {
                        pName: product,
                        pIncome: income
                    }
                ]
            };
            cities.push(cityObj);
        }
    }

    for (let city of cities) {
        console.log(`Town - ${city.cName}`);
        let keys = Object.keys(city.sales);
        for (let i = 0; i < keys.length; i++) {
            console.log(`$$$${city.sales[i].pName} : ${city.sales[i].pIncome}`);
        }
    }

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
        'Sofia -> Laptops HP -> 200 : 2000',
        'Sofia -> Raspberry -> 200000 : 1500',
        'Sofia -> Audi Q7 -> 200 : 100000',
        'Montana -> Portokals -> 200000 : 1',
        'Montana -> Qgodas -> 20000 : 0.2',
        'Montana -> Chereshas -> 1000 : 0.3'
    ]
);