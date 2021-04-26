function solve(text, query) {
    return text.startsWith(query);
}

console.log(solve('How have you been?', 'how'))
console.log(solve('The quick brown fox…', 'The quick brown fox…'))
console.log(solve('How have you been?', 'how'))