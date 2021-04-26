// function solve(input){
//     let arr = input.map(Number);

//     let fE = arr[0];
//     let lE = arr[arr.length - 1];

//     console.log(fE + lE);
// }

//solution with foreach/map... functions
function solve(input){
    let output;
    if (input.length === 1){
        output = input[0] * 2
    } else {
        output = input
        .map((item) => {
            return +item;
        })
        .filter((item, index) => {
            if (index === 0){
                console.log(index === (input.length - 1));
                return item;
            }

            if (index === (input.length - 1)) {
                return item;
            }
        })
        .reduce((acc, cur) => {
            return acc + cur;
        }, 0);
    }
    return output;
}

// console.log(solve(['20', '30', '40']));
// console.log(solve(['5', '10']));
console.log(solve(['4']));

