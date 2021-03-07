function solve(arr) {
    let input = arr.map(Number).sort((a, b) => b-a);

    for (let i = 0; i < 3; i++) {
        if (input[i] !== undefined){
            console.log(input[i]);
        }
    }
}

solve([30, 15]); 