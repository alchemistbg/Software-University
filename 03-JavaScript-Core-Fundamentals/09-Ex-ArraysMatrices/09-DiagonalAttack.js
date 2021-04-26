function solve(inputMatrix){
    for (let i = 0; i < inputMatrix.length; i++) {
        inputMatrix[i] = inputMatrix[i].split(' ').map(Number);
    }

    let sumMainDiag = 0;
    let sumSecDiag = 0;
    for (let i = 0; i < inputMatrix.length; i++) {
        sumMainDiag += inputMatrix[i][i];
        sumSecDiag += inputMatrix[i][inputMatrix.length-1-i];
    }

    if (sumMainDiag === sumSecDiag) {
        for (let i = 0; i < inputMatrix.length; i++) {
            for (let j = 0; j < inputMatrix[i].length; j++) {
                if (i !== j && i !== inputMatrix.length - 1 - j) {
                    inputMatrix[i][j] = sumMainDiag;
                }
            }
        }
    }
    printMatrix(inputMatrix)

    function printMatrix(m){
        for (let i = 0; i < m.length; i++) {
            console.log(m[i].join(' '));
        }
    }

}

solve(
    [
    '5 3 12 3 1',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1'
    ]
);
/*console.log();
solve([
    '1 1 1',
    '1 1 1',
    '1 1 0'
    ]
);*/
