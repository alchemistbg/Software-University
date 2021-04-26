function solve(matrix) {
    let sum = matrix[0].reduce((a, b) => a+b);
    let isMagic = true;
    for (let i = 1; i < matrix.length; i++) {
        let currSum = matrix[i].reduce((a, b) => a+b);
        if (sum !== currSum) {
            isMagic = false;
            break;
        }
    }

    for (let i = 0; i < matrix.length; i++) {
        let col = matrix.map(x => x[i]);
        let currSum = col.reduce((a, b) => a+b);
        if (sum !== currSum) {
            isMagic = false;
            break;
        }
    }
    console.log(isMagic);
}

console.log(solve(
    [
        [4, 5, 6],
        [6, 5, 4],
        [5, 5, 5]
    ]
));
console.log(solve(
    [
        [11, 32, 45],
        [21, 0, 1],
        [21, 1, 1]
    ]
));
console.log(solve(
    [
        [1, 0, 0],
        [0, 0, 1],
        [0, 1, 0]
    ]
));