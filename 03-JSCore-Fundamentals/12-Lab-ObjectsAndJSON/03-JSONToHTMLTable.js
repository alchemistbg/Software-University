function solve(input) {
    let html = '<table>\n  <tr>';
    let objects = JSON.parse(input);

    let keys = Object.keys(objects[0]);
    for (let i = 0; i < keys.length; i++) {
        html = html + `<th>${keys[i]}</th>`;
    }
    html = html + '</tr>\n';

    for (let object of objects) {
        let values = Object.values(object);
        html = html + '  <tr>';
        for (let i = 0; i < values.length; i++) {
            let value = values[i];
            if (typeof value === 'string'){
                value = value
                    .replace(/&/g, '&amp;')
                    .replace(/</g, '&lt;')
                    .replace(/>/g, '&gt;')
                    .replace(/"/g, '&quot;')
                    .replace(/'/g, '&#39;');
            }

            html = html + `<td>${value}</td>`;

        }
        html = html + '</tr>\n';
    }

    html = html + '</table>';
    console.log(html);
}

solve('[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]');