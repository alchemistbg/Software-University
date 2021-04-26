function solve(text, query) {
    let regex = new RegExp(`\\b${query}\\b`, 'gmi');
    let matches = text.match(regex);
    if (matches){
        return matches.length;
    } else {
        return 0;
    }
}

console.log(solve('The waterfall was so high, that the child couldn’t see its peak.', 'the'))
console.log(solve('There was one. Therefore I bought it. I wouldn’t buy it otherwise.', 'there'))