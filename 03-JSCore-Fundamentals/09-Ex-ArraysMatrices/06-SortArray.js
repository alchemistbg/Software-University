function solve(input) {
    console.log(input.sort().sort((w1, w2) => w1.length - w2.length).join('\n'));
}

solve(['alpha', 'beta', 'gamma']);
solve(['Isacc', 'Theodor', 'Jack', 'Harrison', 'George']);
solve(['test', 'Deny', 'omen', 'Default']);