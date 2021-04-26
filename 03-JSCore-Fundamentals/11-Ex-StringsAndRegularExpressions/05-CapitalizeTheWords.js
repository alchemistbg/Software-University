function solve(text) {
    let textArr = text.split(' ');
    //textArr.forEach(x => console.log(x));
    textArr = textArr
        .map(x => x.toLowerCase())
        .map(x => x[0].toUpperCase() + x.substr(1));
    return textArr.join(' ');
}

console.log(solve('Was that Easy? tRY thIs onE for SiZe!'))