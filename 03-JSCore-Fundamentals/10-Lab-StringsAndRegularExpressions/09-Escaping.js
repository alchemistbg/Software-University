function solve(input) {
    let result = '<ul>\n';

    for (let i = 0; i < input.length; i++) {
        input[i] = input[i].replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;');
        result += `  <li>${input[i]}</li>\n`;
    }
    result += '</ul>';
    console.log(result);
    return result;
}

solve(['<b>unescaped text</b>', 'normal text']);
solve(['<b>unescaped text</b>', 'normal text']);