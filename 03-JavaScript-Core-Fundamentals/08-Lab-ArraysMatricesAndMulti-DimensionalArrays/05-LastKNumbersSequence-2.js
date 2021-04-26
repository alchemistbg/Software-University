function solve(n, k) {
    let array = [1];
    for (let i = 1; i < n; i++) {
        let sum = array.slice(Math.max(0, i - k), i).reduce((x, y) => x + y);
        array.push(sum);
    }
    console.log(array);
}

solve(9, 5)