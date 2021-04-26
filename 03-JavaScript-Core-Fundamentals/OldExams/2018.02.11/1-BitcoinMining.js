function solve(input) {
    let totalMoney = 0;
    let totalBitcoins = 0;
    let firstByu = 0;
    for (let i = 0; i < input.length; i++) {
        let workingDay = i + 1;
        if (workingDay % 3 === 0){
            input[i] *= 0.7;
        }
        let curMoney = input[i] * 67.51;
        totalMoney += curMoney;
        if (totalMoney >= 11949.16) {
            if (firstByu === 0) {
                firstByu = workingDay;
            }
            let curBitcoins = Number.parseInt(totalMoney / 11949.16);
            totalBitcoins += curBitcoins;
            totalMoney -= curBitcoins * 11949.16;
        }
    }

    console.log(`Bought bitcoins: ${totalBitcoins}`);
    if (firstByu > 0) {
        console.log(`Day of the first purchased bitcoin: ${firstByu}`);
    }
    console.log(`Left money: ${totalMoney.toFixed(2)} lv.`)
}

solve(['100', '200', '300']);
console.log('='.repeat(30));
solve(['50', '100']);
console.log('='.repeat(30));
solve(['3124.15', '504.212', '2511.124'])