function solve(text) {
    let result = [];

    let start = text.indexOf('(');
    while(start > -1){
            let end = text.indexOf(')', start);
            if (end > -1) {
            result.push(text.substring(start + 1, end));
            start = text.indexOf('(', end);
        }else{
            break;
        }
    }
    console.log(result.join(', '));
}

solve('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)');
console.log();
solve('Rakiya (Bulgarian brandy) is home-made liquor (alcoholic drink). It can be made of grapes, plums or other fruits (even apples).');