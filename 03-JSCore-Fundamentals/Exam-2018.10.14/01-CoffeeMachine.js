function solve(input) {
    let coffeeCaffeine = 0.80;
    let coffeeDecaf = 0.90;
    let tea = 0.80;

    let totalIncome = 0.00;
    for (let iLine of input) {
        let order = iLine.split(', ');
        let coins = +order[0];
        let drink = order[1];
        let coffeeType = '';
        if (drink === 'coffee') {
            coffeeType = order[2];
        }
        let milk = false;
        if (order.includes('milk')){
            milk = true;
        }
        let sugarQty = +order[order.length - 1];

        let orderCost = 0.00;
        switch (drink) {
            case 'coffee':
                if (coffeeType === 'caffeine'){
                    orderCost = coffeeCaffeine;
                }else if (coffeeType === 'decaf'){
                    orderCost = coffeeDecaf;
                }
                break;
            case 'tea':
                orderCost = tea;
        }

        if (milk){
            orderCost = +(orderCost * 1.1).toFixed(1);
        }
        if (sugarQty){
            orderCost += 0.1;
        }

        if (orderCost <= coins){
            console.log(`You ordered ${drink}. Price: ${orderCost.toFixed(2)}$ Change: ${(coins - orderCost).toFixed(2)}$`);
            totalIncome += orderCost;
        }else{
            console.log(`Not enough money for ${drink}. Need ${(orderCost - coins).toFixed(2)}$ more.`);
        }
    }

    console.log(`Income Report: ${totalIncome.toFixed(2)}$`)
}

solve(['1.00, coffee, caffeine, milk, 4',
    '0.40, tea, milk, 2',
    '1.00, coffee, decaf, 0']);
console.log();
solve(['8.00, coffee, decaf, 4',
    '1.00, tea, 2']);