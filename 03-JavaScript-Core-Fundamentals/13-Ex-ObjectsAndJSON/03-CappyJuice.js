function solve(input){
    let juices = [];
    for (let inputLine of input) {
        let inputLineArr = inputLine.split(' => ');
        let juiceName = inputLineArr[0];
        let qty = +inputLineArr[1];

        let juiceIndex = findWithAttr(juices, 'juiceName', juiceName);
        if (juiceIndex > -1){
            juices[juiceIndex].qty += qty;
        } else {
            let juice = {
                juiceName,
                qty,
                bottles: 0,
                firstTime: 0
            };
            juices.push(juice);

        }

        let jIndex = findWithAttr(juices, 'juiceName', juiceName);
        if(juices[jIndex].qty >= 1000){
            juices[jIndex].bottles += Number.parseInt(juices[jIndex].qty / 1000);
            juices[jIndex].qty = juices[jIndex].qty % 1000;

            if (!juices[jIndex].firstTime){
                juices[jIndex].firstTime = 1;
                let tempObj = juices[jIndex];
                juices.splice(jIndex, 1);
                juices.push(tempObj);
            }
        }
    }


    let final = juices.filter(x => x.bottles > 0);
    final.forEach(x => {
        console.log(`${x.juiceName} => ${x.bottles}`);
    });

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
    'Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549'
]);
console.log();
solve([
    'Kiwi => 234',
    'Pear => 2345',
    'Watermelon => 3456',
    'Kiwi => 4567',
    'Pear => 5678',
    'Watermelon => 6789'
]);