function solve(input){
    let html = '<table>\n';

    input.forEach(x => {
        let object = JSON.parse(x);
        html += '    <tr>\n' +
            `        <td>${object.bookName}</td>\n` +
            `        <td>${object.position}</td>\n` +
            `        <td>${object.salary}</td>\n    <tr>\n`;
    });

    html += '</table>';

    console.log(html)
}

solve([
    '{"bookName":"Pesho","position":"Promenliva","salary":100000}',
    '{"bookName":"Teo","position":"Lecturer","salary":1000}',
    '{"bookName":"Georgi","position":"Lecturer","salary":1000}'
]);