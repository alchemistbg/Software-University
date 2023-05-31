let manager = (function solution() {
    let products = {protein: 0, carbohydrate: 0, fat: 0, flavour: 0};

    let recipes = {
        apple: {carbohydrate: 1, flavour: 2},
        coke: {carbohydrate: 10, flavour: 20},
        burger: {carbohydrate: 5, fat: 7, flavour: 3},
        omelet: {protein: 5, fat: 1, flavour: 1},
        cheverme: {protein: 10, carbohydrate: 10, fat: 10, flavour: 10}
    };

    function restock(product, qty) {
        products[product] += qty;
        return 'Success';
    }

    function report() {
        let reportStr = '';
        Object.keys(products).forEach((product) => {
            reportStr += `${product}=${products[product]} `;
        });
        return reportStr.trim();
    }

    function prepare(recipe, qty) {
        let preparationStatus = 'Success';
        let curRecipe = {};
        let curRecipeProducts = [...Object.keys(recipes[recipe])];
        curRecipeProducts.forEach((x) => {
            curRecipe[x] = recipes[recipe][x] * qty;
        });

        for (let i = 0; i < curRecipeProducts.length; i++) {
            if (curRecipe[curRecipeProducts[i]] > products[curRecipeProducts[i]]){
                return `Error: not enough ${curRecipeProducts[i]} in stock`;
            }
        }
            for (let i = 0; i < curRecipeProducts.length; i++) {
                products[curRecipeProducts[i]] -= curRecipe[curRecipeProducts[i]];
            }
        return preparationStatus;
    }

    return function commandsParse(input) {
        let commandTokens = input.split(' ');
        let command = commandTokens[0];
        switch (command) {
            case 'restock':
                return restock(commandTokens[1], +commandTokens[2]);
            case 'prepare':
                return prepare(commandTokens[1], +commandTokens[2]);
            case 'report':
                return report();
        }
    }

}());

console.log(manager("restock flavour 50"));
console.log(manager("prepare coke 4"));
console.log(manager("restock carbohydrate 50"));
console.log(manager("prepare coke 4"));
console.log(manager("restock flavour 40"));
console.log(manager("prepare coke 4"));
console.log(manager("report"));

// console.log(manager("report"));

