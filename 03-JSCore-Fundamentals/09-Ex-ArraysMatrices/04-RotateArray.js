function solve(input) {
    let initialRot = Number(input.pop());
    let finalRot = initialRot % input.length;
    for (let i = 0; i < finalRot; i++) {
        input.unshift(input.pop());
    }

    console.log(input.join(' '));
}

solve(['1', '2', '3', '4', '2']);
console.log();
solve(['Banana', 'Orange', 'Coconut', 'Apple', '1000']);