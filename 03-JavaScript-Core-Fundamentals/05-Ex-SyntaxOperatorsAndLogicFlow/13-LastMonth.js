function solve([d, m, y]) {
    let date = new Date(y, m-1, 0);
    console.log(date.getDate());
}

solve([17, 3, 2002]);
solve([13, 12, 2004]);