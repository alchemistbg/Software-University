function solve(number) {
    let str = "$";
    for (let i = 1; i <= number; i++) {
        console.log(str.repeat(i));
    }
}

solve(4);