function solve(input){
    let p1 = {bookName: 1, x: input[0], y: input[1]};
    let p2 = {bookName: 2, x: input[2], y: input[3]};
    let p3 = {bookName: 3, x: input[4], y: input[5]};

    let d = {dist12:calcDist(p1, p2), dist23:calcDist(p2, p3), dist13:calcDist(p1, p3)};
    let dSorted = Object.keys(d).sort((a, b) => d[a] - d[b]);

    switch (dSorted[2]) {
        case 'dist13':
            console.log(`1->2->3: ${d.dist12 + d.dist23}`);
            break;
        case 'dist23':
            console.log(`2->1->3: ${d.dist12 + d.dist13}`);
            break;
        case 'dist12':
            console.log(`1->3->2: ${d.dist13 + d.dist23}`);
            break;
    }

    function calcDist(p1, p2) {
        let dist = Math.sqrt(Math.pow((p1.x - p2.x), 2) + Math.pow((p1.y - p2.y), 2));
        return dist;
    }
}

solve([0, 0, 2, 0, 4, 0]);
solve([5, 1, 1, 1, 5, 4]);
solve([-1, -2, 3.5, 0, 0, 2]);