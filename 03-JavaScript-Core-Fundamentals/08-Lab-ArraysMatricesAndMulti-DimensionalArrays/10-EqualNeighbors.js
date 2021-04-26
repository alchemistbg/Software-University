function solve(matrix) {
    let counter = 0;

    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            if (matrix[i][j] === matrix[i][j + 1]) {
                counter++;
            }

            if (matrix[i+1] !== undefined && matrix[i][j] === matrix[i + 1][j]) {
                counter++;
            }
        }
    }
    console.log(counter);
}

// solve(
//     [
//         ['2', '3', '4', '7', '0'],
//         ['4', '0', '5', '3', '4'],
//         ['2', '3', '5', '4', '2'],
//         ['9', '8', '7', '5', '4']
//     ]
// );
// solve(
//     [
//         ['test', 'yes', 'yo', 'ho'],
//         ['well', 'done', 'yo', '6'],
//         ['not', 'done', 'yet', '5']
//
//     ]
// );
solve(
    [
        [2, 2, 5, 7, 4],
        [4, 0, 5, 3, 4],
        [2, 5, 5, 4, 2]

    ]
);

