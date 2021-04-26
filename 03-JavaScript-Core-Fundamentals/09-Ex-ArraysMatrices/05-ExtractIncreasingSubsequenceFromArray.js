function solve(arr) {
    let filtered = (arr.filter((e, i, a) => a[i] >= a[i+1]));
    //console.log(filtered);
    let filteredArr = [arr[0]];

    for (let i = 1; i < arr.length; i++) {
        if (arr[i] >= filteredArr[filteredArr.length-1]) {
            filteredArr.push(arr[i]);
        }
    }
    console.log(filteredArr.join('\n'));
}

solve([1, 3, 8, 4, 10, 12, 3, 2, 24]);
solve([1, 2, 3, 4]);
solve([20, 3, 2, 15, 6, 1]);