function calendar([iDay, iMonth, iYear]) {
    let locale = "en-us";

    let fullDate = new Date(iYear, iMonth - 1, iDay);
    let monthName = fullDate.toLocaleString(locale, {month: "long"});

    let daysInCurrMonth = new Date(iYear, iMonth, 0).getDate();
    let firstDayInMonth = new Date(iYear, iMonth - 1, 1).getDay() - 1;
    if (firstDayInMonth === -1){
        firstDayInMonth = 6;
    }
    let lastDayInMonth = new Date(iYear, iMonth - 1, daysInCurrMonth).getDay() - 1;
    if (lastDayInMonth === -1){
        lastDayInMonth = 6;
    }

    let daysFromPrevMonth = firstDayInMonth;
    let daysFromNextMonth = 6 - lastDayInMonth;

    let totalDays = daysFromPrevMonth + daysInCurrMonth + daysFromNextMonth;
    console.log(`prev: ${daysFromPrevMonth}; curr: ${daysInCurrMonth}; next: ${daysFromNextMonth}; total: ${totalDays}`)

    let $tableCaptionContainer = $('<caption>').text(`${monthName} ${iYear}`);
    let $tableBodyContainer = $('<tbody>');
    let $tableHeaderContainer = $('<tr>');
    let daysInWeek = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];
    daysInWeek.forEach((x) => {
        let $dayOfWeekContainer = $('<th>').text(x.substring(0, 3));
        $tableHeaderContainer.append($dayOfWeekContainer);
    });

    let $tableContainer = $('<table>')
        .append($tableCaptionContainer)
        .append($tableBodyContainer)
        .append($tableHeaderContainer);

    let $tRow = $('<tr>');
    for (let i = 1; i <= totalDays; i++) {
        let $tableCell = $('<td>');
        if (i > daysFromPrevMonth && i <= totalDays - daysFromNextMonth) {
            $tableCell.text(i - daysFromPrevMonth);
            $tableCell.on('click', () => {
                console.log(`Today is: ${i - daysFromPrevMonth} ${monthName}; ${iYear}`);
            });
            if (i - daysFromPrevMonth === fullDate.getDate()) {
                $tableCell.addClass('today');
            }
            rowsMaker($tableCell, i);
        }else{
            rowsMaker($tableCell, i);
        }
    }

   function rowsMaker($tCell, counter) {
        if (counter % 7 === 0) {
            $tRow.append($tCell);
            $tRow.appendTo($tableBodyContainer);
            $tRow = $('<tr>');
        } else {
            $tRow.append($tCell);
        }
    }

    $('#content').append($tableContainer);
}