function solve(rows, cols){
    let elements = rows * cols;
    let matrix = [];
    for (let i = 0; i < rows; i++) {
        matrix[i] = [];
        let row = [];
        for (let j = 0; j < cols; j++) {
            row.push(0);
        }
        matrix[i] = [].concat(row)
    }

    let number = 1;
    //left-to-right
        for (let j = 0; j < rows/2; j++) {
            for (let i = 0; i < cols; i++){
            matrix[j][i] = number;
            number++;
        }
    }

    for (let i = 0; i < rows; i++) {
        console.log(matrix[i].join('; '));
    }
    //console.log(matrix);
}

solve(5, 5);
// solve(3, 3);