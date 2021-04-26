function solve(input) {
    let products = [];

    for (let inputLine of input) {
        let [cityName, productName, productPrice] = inputLine.split(' | ');

        let indexProduct = findWithAttr(products, 'pName', productName);
        if (indexProduct > -1) {
            let indexCity = findWithAttr(products[indexProduct].cities, 'cName', cityName);
            if (indexCity > -1){
                products[indexProduct].cities[indexCity].price = +productPrice;
            } else {
                let cityObj = {
                    cName: cityName,
                    price: +productPrice
                };
                products[indexProduct].cities.push(cityObj);
            }
        } else {
            let productObj = {
                pName: productName,
                cities: [
                    {
                        cName: cityName,
                        price: +productPrice
                    }
                ]
            };
            products.push(productObj);
        }
    }

    for (let i = 0; i < products.length; i++) {
        let sortedCities = products[i].cities.sort((a, b) => a.price - b.price);
        console.log(`${products[i].pName} -> ${products[i].cities[0].price} (${products[i].cities[0].cName})`);
    }

    function findWithAttr(array, attr, value) {
        for (let i = 0; i < array.length; i += 1) {
            if (array[i][attr] === value) {
                return i;
            }
        }
        return -1;
    }
}

solve([
    'Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10'
]);
console.log()
solve([
    'Sofia City | Audi | 100000',
    'Sofia City | BMW | 100000',
    'Sofia City | Mitsubishi | 10000',
    'Sofia City | Mercedes | 10000',
    'Sofia City | NoOffenseToCarLovers | 0',
    'Mexico City | Audi | 1000',
    'Mexico City | BMW | 99999',
    'New York City | Mitsubishi | 10000',
    'New York City | Mitsubishi | 1000',
    'Mexico City | Audi | 100000',
    'Washington City | Mercedes | 1000',
]);