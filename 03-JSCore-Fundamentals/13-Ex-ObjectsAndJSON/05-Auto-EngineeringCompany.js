function solve(input) {
    let carsDB = [];
    for (let iLine of input) {
        let iLineArr = iLine.split(' | ');
        let carBrand = iLineArr[0];
        let carModel = iLineArr[1];
        let producedCars = +iLineArr[2];

        let brandIndex = findWithAttr(carsDB, 'carBrand', carBrand);
        if (brandIndex > -1){
            let carIndex = findWithAttr(carsDB[brandIndex].cars, 'carModel', carModel);
            if (carIndex > -1){
               carsDB[brandIndex].cars[carIndex].producedCars += producedCars;
            } else {
                let modelObj = {
                    carModel,
                    producedCars
                }
                carsDB[brandIndex].cars.push(modelObj);
            }
        } else {
            let carObj = {
                carBrand,
                cars: [
                    {
                        carModel,
                        producedCars
                    }
                ]
            };

            carsDB.push(carObj);
        }
    }

    carsDB.forEach(
        function(x){
            console.log(x.carBrand);
            x.cars.forEach(
                function (y){
                    console.log(`###${y.carModel} -> ${y.producedCars}`)
                }
            )
        }
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

solve([
    'Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10'
]);
