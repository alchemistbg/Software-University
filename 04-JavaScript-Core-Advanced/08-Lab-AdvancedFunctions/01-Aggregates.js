function solve(data) {
    let sum = data.reduce((acc, cur) => {
        return acc += cur;
    }, 0);

    let min = data.reduce((acc, cur) => {
        return Math.min(acc, cur);
    }, Number.MAX_SAFE_INTEGER);

    let max = data.reduce((acc, cur) => {
        return Math.max(acc, cur);
    }, Number.MIN_SAFE_INTEGER);

    let product = data.reduce((acc, cur) => {
        return acc *= cur;
    }, 1);

    let join = data.reduce((acc, cur) => {
        return acc += cur;
    }, '');

    console.log(`Sum = ${sum}`);
    console.log(`Min = ${min}`);
    console.log(`Max = ${max}`);
    console.log(`Product = ${product}`);
    console.log(`Join = ${join}`);
}

solve([2,3,10,5]);
solve([5, -3, 20, 7, 0.5]);