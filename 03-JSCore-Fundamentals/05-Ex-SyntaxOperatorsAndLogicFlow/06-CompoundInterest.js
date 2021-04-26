function solve ([p, i, n, t]){
    let freq = 12/n;
    let nomRate = i/100;
    let money = p*Math.pow((1 + nomRate/freq), freq*t);
    console.log(money.toFixed(2));
}

solve([1500, 4.3, 3, 6]);
solve([100000, 5, 12, 25]);