function solve(input) {
    let set = [];
    for (let iLine of input) {
        let iLineArr = JSON.parse(iLine).map(Number).sort((a, b) => b - a);
        let iLineArrSum = iLineArr.reduce((a, b) => a + b);
        
        if (!set.find(x => x.reduce((a, b) => a+b) === iLineArrSum)){
            set.push(iLineArr);
        }
    }

    set.sort((a, b) => a.length - b.length)
        .forEach(x => {
        //let arr = JSON.parse(x);
        console.log(`[${x.join(', ')}]`);
    });
}

solve([
    "[-3, -2, -1, 0, 1, 2, 3, 4]",
    "[10, 1, -17, 0, 2, 13]",
    "[4, -3, 3, -2, 2, -1, 1, 12]", //added by me
    "[4, -3, 3, -2, 2, -1, 1, 0]"
]);
console.log();
solve([
    "[7.14, 7.180, 7.339, 80.099]",
    "[7.339, 80.0990, 7.140000, 7.18]",
    "[7.339, 7.180, 7.14, 80.099]"
]);
