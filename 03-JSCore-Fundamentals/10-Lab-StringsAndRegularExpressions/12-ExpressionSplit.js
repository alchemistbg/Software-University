function solve(input) {
    console.log(input.match(/[^ (),;.]+/g).join('\n'))
}

solve('let sum = 4 * 4,b = "wow";');