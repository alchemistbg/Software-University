function solve(n, k) {
    let array = [1];
    for (let i = 1; i < n; i++) {
        let a = array.slice(Math.max(0, i - k), i);
        let sum = 0;
        for (let j = 0; j < a.length; j++) {
            sum += a[j];
        }
        array.push(sum);
    }
    console.log(array);
}

solve(9, 5)