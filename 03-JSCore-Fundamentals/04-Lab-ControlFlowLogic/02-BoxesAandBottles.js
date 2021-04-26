function solve(bottlesNumber, boxesCapacity) {
    let boxes = bottlesNumber/boxesCapacity;
    console.log(Math.ceil(boxes));
}

solve(
    20,
    5
);
solve(
    15,
    7
);
solve(
    5,
    10
);