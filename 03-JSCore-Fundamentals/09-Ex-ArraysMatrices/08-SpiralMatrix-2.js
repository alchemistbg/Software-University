function solve(rows, cols) {
    let t = 0, b = rows - 1, l = 0, r = cols - 1;
    let dir = 0;

    let matrix = [];
    for (let i = 0; i < rows; i++) {
        matrix[i] = [];
    }

    let currentEllement = 1;
    while(t <= b && l <= r){
        if (dir === 0){
            for (let i = l; i <= r; i++) {
                matrix[t][i] = currentEllement;
                currentEllement++;
            }
            t++;
            dir = 1;
        }else if (dir === 1){
            for (let i = t; i <= b; i++) {
                matrix[i][r] = currentEllement;
                currentEllement++;
            }
            r--;
            dir = 2;
        }else if (dir === 2){
            for (let i = r; i >= l; i--){
                matrix[b][i] = currentEllement;
                currentEllement++;
            }
            b--;
            dir = 3
        }else if(dir === 3){
            for (let i = b; i >= t; i--) {
                matrix[i][l] = currentEllement;
                currentEllement++;
            }
            l++;
            dir = 0;
        }
    }
    
    for (let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(' '))
    }
}

solve(5, 5);