function solve(input) {
    let coffies = [];
    for (let iLine of input) {
        let iLineArr = iLine.split(', ');
        let command = iLineArr[0];
        if (iLineArr.length === 5) {
            let brand = iLineArr[1];
            let type = iLineArr[2];
            let expDate = iLineArr[3];
            let qty = +iLineArr[4];

            if (command === 'IN') {
                let brandIndex = findWithAttr(coffies, 'brand', brand);
                if (brandIndex > -1) {
                    let typeIndex = findWithAttr(coffies[brandIndex].types, 'type', type);
                    if (typeIndex > -1) {
                        if (coffies[brandIndex].types[typeIndex].expDate === expDate){
                            coffies[brandIndex].types[typeIndex].qty += qty;
                        }else{
                            if (coffies[brandIndex].types[typeIndex].expDate < expDate){
                                coffies[brandIndex].types[typeIndex].expDate = expDate;
                                coffies[brandIndex].types[typeIndex].qty = qty;
                            }
                        }
                    } else {
                        let typeObj = {
                            type: type,
                            expDate: expDate,
                            qty: qty
                        }
                        coffies[brandIndex].types.push(typeObj);
                    }
                } else {
                    let coffeeObj = {
                        brand: brand,
                        types: [
                            {
                                type: type,
                                expDate: expDate,
                                qty: qty
                            }
                        ]
                    };
                    coffies.push(coffeeObj);
                }
            } else if (command === 'OUT') {
                let orderCoffeeIndex = findWithAttr(coffies, 'brand', brand);
                if (orderCoffeeIndex > -1){
                    let orderCoffeeTypeIndex = findWithAttr(coffies[orderCoffeeIndex].types, 'type', type);
                    if (orderCoffeeTypeIndex > -1){
                        if (coffies[orderCoffeeIndex].types[orderCoffeeTypeIndex].expDate >= expDate &&
                            coffies[orderCoffeeIndex].types[orderCoffeeTypeIndex].qty >= qty){
                            coffies[orderCoffeeIndex].types[orderCoffeeTypeIndex].qty -= qty;
                        }
                    }
                }
            }
        } else if (iLineArr.length === 1){
            if (command === 'REPORT'){
                console.log('>>>>> REPORT! <<<<<');
                for (let i = 0; i < coffies.length; i++) {
                    console.log(`Brand: ${coffies[i].brand}:`);
                    for (let j = 0; j < coffies[i].types.length; j++) {
                        console.log(`-> ${coffies[i].types[j].type} -> ${coffies[i].types[j].expDate} -> ${coffies[i].types[j].qty}.`);
                    }
                }
            }else if (command === 'INSPECTION'){
                console.log('>>>>> INSPECTION! <<<<<');
                coffies.sort((a, b) => {
                    return a.brand.localeCompare(b.brand);
                });

                for (let i = 0; i < coffies.length; i++) {
                    console.log(`Brand: ${coffies[i].brand}:`);
                    coffies[i].types.sort((a, b) => {
                        return b.qty - a.qty;
                    });
                    for (let j = 0; j < coffies[i].types.length; j++) {
                        console.log(`-> ${coffies[i].types[j].type} -> ${coffies[i].types[j].expDate} -> ${coffies[i].types[j].qty}.`);
                    }
                }
            }
        }


    }

    //console.log(coffies);

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
    "IN, Batdorf & Bronson, Espresso, 2025-05-25, 20",
    "IN, Folgers, Black Silk, 2023-03-01, 14",
    "IN, Lavazza, Crema e Gusto, 2023-05-01, 5",
    "IN, Lavazza, Crema e Gusto, 2023-05-01, 100",//
    "IN, Lavazza, Crema e Gusto, 2023-05-02, 5",
    "IN, Folgers, Black Silk, 2022-01-01, 10",
    "IN, Lavazza, Intenso, 2022-07-19, 20",
    "OUT, Dallmayr, Espresso, 2022-07-19, 5",
    "OUT, Dallmayr, Crema, 2022-07-19, 5",
    "OUT, Lavazza, Crema e Gusto, 2020-01-28, 2",
    "REPORT",
    "INSPECTION"
]);