function solve(input) {
        let matches = input.match(/\b_[A-Za-z\d]+\b/g).map(x => x.slice(1));
    return matches.join();
}

console.log(solve('The _id and _age variables are both integers.'))
console.log(solve('Calculate the _area of the _perfectRectangle object.'))
console.log(solve('__invalidVariable _evenMoreInvalidVariable_ _validVariable'))