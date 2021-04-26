function solve([d, m, y]){
    let date = new Date(y, m-1, d);

    let daysInCurrMonth = new Date(y, m, 0).getDate();
    let firstDayInMonth = new Date(y, m-1, 1).getDay();
    let lastDayInMonth = new Date(y, m-1, daysInCurrMonth).getDay();

    let daysFromPrevMonth = firstDayInMonth;
    let daysFromNextMonth = 6 - lastDayInMonth;

    let calendar = '<table>\n  <tr><th>Sun</th><th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th></tr>\n  <tr>';

    let counter = 1;

    for (let j = daysFromPrevMonth-1; j >=0; j--) {
        let d = new Date(y, m-1, 0);
        calendar += `<td class="prev-month">${d.getDate() - j}</td>`;
        counter++;
    }

    for (let i = 1; i <= daysInCurrMonth; i++) {
            if (i == date.getDate()) {
            calendar += `<td class="today">${i}</td>`;
        }else {
            calendar += `<td>${i}</td>`;
        }
        if (counter % 7 === 0) {
            if (daysFromNextMonth == 0 && i == daysInCurrMonth) {
                calendar += "</tr>\n";
            }else {
                calendar += "</tr>\n  <tr>";
            }
        }
        counter++;
    }

    for (let i = 0; i < daysFromNextMonth; i++) {
        calendar += `<td class="next-month">${i+1}</td>`;
    }

    if (daysFromNextMonth == 0) {
        calendar += '</table>';
    }else {
        calendar += '</tr>\n</table>';
    }
    console.log(calendar);
}

//solve([24, 12, 2012]);
//solve([4, 9, 2016]);
solve([1, 4, 2016]);