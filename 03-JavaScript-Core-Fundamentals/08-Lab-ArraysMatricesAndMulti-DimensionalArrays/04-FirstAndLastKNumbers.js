function solve(input) {
    let k = input[0];

    let fK = input.slice(1, k + 1);
    console.log(fK.join(' '));

    let lK = input.slice(input.length - k, k + (input.length - k));
    console.log(lK.join(' '));

}

solve([2, 7, 8, 9]);
solve([3, 6, 7, 8, 9]);
// solve([2, 7, 8, 9]);