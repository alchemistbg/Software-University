// function solve(arr) {
//     //console.log(arr.filter((arr, i) => i % 2 == 1).map(x => x * 2).reverse().join(' '));
//     let result = [];
//     for (let i = 0; i < arr.length; i++) {
//         if (i % 2 === 1) {
//             result.push(arr[i] * 2)
//         }
//     }
//     console.log(result.reverse());
// }

// solve([10, 15, 20, 25]);

function solve(input){
    let result = input
        .filter((item, index) => {
            return (index % 2) != 0;
        })
        .map((item) => {
            return item * 2;
        })
        .reverse();
    
    return result;
}

console.log(solve([10, 15, 20, 25]));