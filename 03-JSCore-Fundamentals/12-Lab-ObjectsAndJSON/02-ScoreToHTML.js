function solve(input) {
    let html = '<table>\n  <tr><th>bookName</th><th>score</th></tr>\n';
    let objects = JSON.parse(input);
    for (let obj of objects) {
        let pName = obj.bookName
            .replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
        let pScore = obj.score;
        html = html + `  <tr><td>${pName}</td><td>${pScore}</td></tr>\n`;
    }
    html = html + '</table>';
    console.log(html);
}

solve(['[{"bookName":"Pesho & Kiro","score":479},{"bookName":"Gosho, Maria & Viki","score":205}]']);
// solve([{"bookName":"Pesho","score":479},{"bookName":"Gosho","score":205}]);
// console.log()
// solve([{"bookName":"Pesho & Kiro","score":479},{"bookName":"Gosho, Maria & Viki","score":205}]);