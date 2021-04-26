function solve(input) {
    let atmTotalSum = 0;
    let atmBanknotes = {};

    for (let iLine of input) {
        if (iLine.length > 2) {
            for (let i = 0; i < iLine.length; i++) {
                if (!atmBanknotes.hasOwnProperty(iLine[i])) {
                    atmBanknotes[iLine[i]] = 1;
                } else {
                    atmBanknotes[iLine[i]]++;
                }
            }
            let atmCurrSum = iLine.reduce((a, b) => a + b);
            atmTotalSum += atmCurrSum;
            console.log(`Service Report: ${atmCurrSum}$ inserted. Current balance: ${atmTotalSum}$.`);
        } else if (iLine.length === 2) {
            let accountBalance = iLine[0];
            let withdrawMoney = iLine[1];

            if (accountBalance < withdrawMoney) {
                console.log(`Not enough money in your account. Account balance: ${accountBalance}$.`);
            } else if (withdrawMoney > atmTotalSum) {
                console.log('ATM machine is out of order!');
            } else {
                atmTotalSum -= withdrawMoney;
                let currWithdrawMoney = withdrawMoney;
                let atmBanknotesKeys = Object.keys(atmBanknotes);

                for (let i = atmBanknotesKeys.length - 1; i >= 0; i--) {
                    if (currWithdrawMoney === 0) {
                        break;
                    } else {
                        if (atmBanknotes[atmBanknotesKeys[i]] > 0) {
                            if (currWithdrawMoney >= atmBanknotesKeys[i]) {
                                let banknotesNumber = Number.parseInt(currWithdrawMoney / atmBanknotesKeys[i]);
                                currWithdrawMoney -= atmBanknotesKeys[i] * banknotesNumber;
                                atmBanknotes[atmBanknotesKeys[i]] -= banknotesNumber;
                            }
                        }
                    }
                }
                console.log(`You get ${withdrawMoney}$. Account balance: ${accountBalance - withdrawMoney}$. Thank you!`);
            }
        } else {
            if (atmBanknotes[iLine[0]]){
                console.log(`Service Report: Banknotes from ${iLine[0]}$: ${atmBanknotes[iLine[0]]}.`);
            } else{
                console.log(`Service Report: Banknotes from ${iLine[0]}$: 0.`);
            }
        }
    }
}

solve([
    [20, 20, 5, 100, 20, 100, 20, 500, 1, 1000],
    // [457, 265],
    // [5],
    // [20],
    // [100],
    // [20, 5, 20],
    // [20],
    [50]
    //[1000],
    //[10, 10, 5, 20, 50, 20, 10, 5, 2, 100, 20],
    //[5],//
    //[20, 85],
    //[5000, 4500]
]);