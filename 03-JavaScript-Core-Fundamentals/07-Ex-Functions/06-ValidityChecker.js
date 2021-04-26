function solve(input) {
    let p0 = {x:0, y: 0};
    let p1 = {x:input[0], y: input[1]};
    let p2 = {x:input[2], y: input[3]};

    console.log(isValidDistance(p1, p0));
    console.log(isValidDistance(p2, p0));
    console.log(isValidDistance(p1, p2));

    function isValidDistance(pointA, pointB) {
        let message = `{${pointA.x}, ${pointA.y}} to {${pointB.x}, ${pointB.y}} is `;
        let distance = Math.sqrt(Math.pow(pointA.x-pointB.x, 2) + Math.pow(pointA.y - pointB.y, 2));
        if (Number.isInteger(distance)) {
            message += `valid`;
        }else {
            message += `invalid`;
        }
        return message;
    }
}

solve([3, 0, 0, 4]);
solve([2, 1, 1, 1]);