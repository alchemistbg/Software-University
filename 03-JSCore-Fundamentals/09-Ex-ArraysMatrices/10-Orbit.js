//TO FIX CASES LIKE: [6, 6, 3, 3] or [3, 3, 2, 2]
function solve([rows, cols, p1, p2]) {
    let matrix = [];
    for (let i = 0; i < rows; i++) {
        matrix.push('0'.repeat(cols).split('').map(Number));
    }

    let limit = rows - p1;
    let element = 1;
    matrix[p1][p2] = element;

    while (element < limit){
        let p1Up = p1 - element;
        if (p1Up < 0){
            p1Up = 0
        }
        let p1Down = p1 + element;
        if (p1Down < 0){
            p1Down = 0
        }
        let p2Left = p2 - element;
        if (p2Left < 0){
            p2Left = 0
        }
        let p2Right = p2 + element;
        if (p2Right < 0){
            p2Right = 0
        }
        for (let i = p1Up; i <= p1Down; i++) {
            for (let j = p2Left; j <= p2Right; j++) {
                if (matrix[i][j] === 0) {
                    matrix[i][j] = element+1;
                }
            }
        }
        element++;
    }

    for (let i = 0; i < rows; i++) {
        console.log(matrix[i].join(' '));
    }
}

solve([4, 4, 0, 0]);
solve([5, 5, 2, 2]);
// solve([6, 6, 2, 2]);
// solve([6, 6, 3, 3]);
// solve([3, 3, 2, 2]);