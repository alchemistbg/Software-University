function solve(matrix) {
    let mainDiagSum = 0;
    let secDiagSum = 0;
    for (let i = 0; i < matrix.length; i++) {
        mainDiagSum += matrix[i][i];
        secDiagSum += matrix[i][matrix.length - 1 - i]
        /*for (let j = 0; j < matrix[i].length; j++) {
            if (i === j) {
                mainDiagSum += matrix[i][j];
            }

            if (i == j) {
                secDiagSum += matrix[i][matrix[i].length-1-j];
            }
        }*/
    }
    console.log(mainDiagSum + ' ' + secDiagSum);
}

solve([
    [3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]
    ]);