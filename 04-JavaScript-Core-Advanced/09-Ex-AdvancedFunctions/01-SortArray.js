function solve(array, sorter){
    let sortAsc = function (a, b){
        return a - b;
    };

    let sortDesc = function (a, b) {
        return b-a;
    };

    let sortType = {
        'asc': sortAsc,
        'desc': sortDesc
    }

    return array.sort(sortType[sorter]);
}

console.log(solve([14, 7, 17, 6, 8], 'asc'));
console.log(solve([14, 7, 17, 6, 8], 'desc'))