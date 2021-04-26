// function solve(input) {
//     let result = [];
//     for (let item of input) {
//         if (item < 0) {
//             result.unshift(item)
//         } else {
//             result.push(item)
//         }
//     }

//     console.log(result.join('\n'));
// }

// solve([7, -2, 8, 9]);
// solve([3, -2, 0, -1]);


function solve(input){
    let negative = input
        .filter((i) => {
                return i < 0;
        });
    
    let positive = input
        .filter((k) => {
                return k >= 0;
        });
    
    let result = [].concat(negative.reverse()).concat(positive).join('\n');
    return result;
}

console.log(solve([7, -2, 8, 9]));
console.log(solve([3, -2, 0, -1]));