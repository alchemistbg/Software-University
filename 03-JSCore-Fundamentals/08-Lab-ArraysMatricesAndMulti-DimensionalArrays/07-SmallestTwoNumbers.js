function solve(arr) {
    console.log(arr.sort((a, b) => a-b).filter((e, i) => i < 2).join(' '));
}

solve([30, 15, 50, 5]);
solve([3, 0, 10, 4, 7, 3]);