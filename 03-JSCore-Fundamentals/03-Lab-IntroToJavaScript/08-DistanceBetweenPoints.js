function solve(x1, y1, x2, y2) {
    let distance = 0.0;
    let point1 = {x:x1, y:y1}
    let point2 = {x:x2, y:y2}
    calcDistance(point1, point2);

    function calcDistance(p1, p2){
        distance = Math.sqrt(Math.pow((p1.x - p2.x), 2) + Math.pow((p1.y - p2.y), 2));
    }
    console.log(distance);
}

solve(2, 4, 5, 0);
solve(2.34, 15.66, -13.55, -2.9985);