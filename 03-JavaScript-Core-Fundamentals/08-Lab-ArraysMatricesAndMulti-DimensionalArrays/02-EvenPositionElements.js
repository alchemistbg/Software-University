// function solve(input) {
//     let resultArr = [];
//     for (let i in input) {
//         if (i % 2 == 0) {
//             resultArr.push(input[i]);
//         }
//     }
//     console.log(resultArr.join(' '))
// }

function solve(input) {

    let evenPos = input
        .filter((item, index) => {
            if ((index % 2) === 0){
                return item;
            }
        }).join(' ');
    
    return evenPos;
}

console.log(solve([20, 30, 40]));
