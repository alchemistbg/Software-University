function solve(input) {
    let sum = 0;
    let invSum = 0;
    let inputString = '';
    for (let i = 0; i < input.length; i++) {
        sum += input[i];
        invSum += 1/input[i];
        inputString += input[i];
        //console.log(typeof input[i]);
    }
    console.log(sum);
    console.log(invSum);
    console.log(inputString);
}

solve([1, 2, 3]);
solve([2, 4, 8, 16]);