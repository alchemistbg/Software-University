function solve(matrix) {
    let biggest = Number.MIN_SAFE_INTEGER;
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            if (biggest < matrix[i][j]) {
                biggest = matrix[i][j];
            }
        }
    }
    console.log(biggest);
}

solve([[20, 50, 10],
    [8, 33, 145]]
);