function solve(input) {
    let catalogue = [];
    for (let inputLine of input) {
        let arr = inputLine.split(' : ');
        let fLetter = arr[0][0].toUpperCase();

        let pName = arr[0];
        let pPrice = +arr[1];
        let product = {
            pName,
            pPrice
        }

        let index = findWithAttr(catalogue, 'fLetter', fLetter);
        if (index > -1){
            catalogue[index].product.push(product);
        } else{
            let obj = {
                fLetter,
                product: [
                    {
                        pName,
                        pPrice
                    }
                ]
            }
            catalogue.push(obj);
        }
    }

    let sortedCatalogue = catalogue.sort(
        function(a,b) {
            return (a.fLetter > b.fLetter) ? 1 : ((b.fLetter > a.fLetter) ? -1 : 0);
        });

    for (let item of sortedCatalogue) {
        console.log(item.fLetter);

        let sortedProducts = item.product.sort(
            function(a, b) {
                return (a.pName.toUpperCase() > b.pName.toUpperCase()) ? 1 : ((b.pName.toUpperCase() > a.pName.toUpperCase()) ? -1 : 0);
            }
        );
        for (let i = 0; i < sortedProducts.length; i++) {
            console.log(` ${sortedProducts[i].pName}: ${sortedProducts[i].pPrice}`);
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

solve([
    'Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10'
]);
console.log();
solve([
    'Banana : 2',
    'Rubic\'s Cube : 5',
    'Raspberry P : 4999',
    'Rolex : 100000',
    'Rollon : 10',
    'Rali Car : 2000000',
    'Pesho : 0.000001',
    'Barrel : 10'
]);