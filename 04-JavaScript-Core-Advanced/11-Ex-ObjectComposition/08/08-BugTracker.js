function bugTracker() {
    let bugCount = (function () {
        let counter = 0;
        return function () {
            return counter++;
        }
    }());

    let contentSelector = '';
    return {
        report: function (author, description, reproducible, severity) {
            let bug = {
                id: 'report_' + bugCount(),
                author: bookAuthor,
                description,
                reproducible,
                severity,
                status: 'Open'
            };
            let $parentElem = $(contentSelector);

            let $bugDescription = $('<p>').text(bug.description);

            let $bugBody = $('<div>').addClass('body').append($bugDescription);

            let $bugTitle = $('<div>').addClass('title');
            let $bugAuthor = $('<span>').addClass('bookAuthor').text(`Submitted by: ${bug.bookAuthor}`);
            let $bugStatus = $('<span>').addClass('status').text(`${bug.status} | ${bug.severity}`);

            let $bugElem = $('<div>')
                .attr('id', bug.id)
                .addClass('report');

            $bugElem.append($bugBody);
            $bugTitle.append($bugAuthor);
            $bugTitle.append($bugStatus);
            $bugElem.append($bugTitle);
            $parentElem.append($bugElem);

        },
        setStatus: function (id, status) {
            let $bug = $(`#report_${id} .status`);
            let oldBugInfo = $bug.text().split(' | ');

            $bug.text(`${status} | ${oldBugInfo[1]}`);
        },
        remove: function (id) {
            $(`#report_${id}`).remove();
        },
        sort: function (criteria) {
            switch (criteria) {
                case undefined:
                case 'ID':
                    let $elemsSortByID = $('.report');
                    $elemsSortByID.sort((a, b) => {
                        if (a.id > b.id){
                            return 1
                        } else {
                            return -1
                        }
                    }).each(function () {
                        let elem = $(this);
                        elem.remove();
                        $(elem).appendTo(contentSelector);
                    });
                    break;
                case 'bookAuthor':
                    let $elemsSortByAuthor = $('.report .title .bookAuthor');
                    $elemsSortByAuthor.sort((a, b) => {
                        if (a.textContent.split(': ')[1] > b.textContent.split(': ')[1]){
                            return 1;
                        } else {
                            return -1
                        }
                    }).each(function () {
                        let elem = $(this.parentNode.parentNode);
                        elem.remove();
                        $(elem).appendTo(contentSelector);
                    });
                    break;
                case 'severity':
                    let $elemsSortBySeverity = $('.report .title .status');
                    $elemsSortBySeverity.sort((a, b) => {
                        if (+a.textContent.split(' | ')[1] > +b.textContent.split(' | ')[1]){
                            return 1;
                        }else{
                            return -1;
                        }
                    }).each(function () {
                        let elem = $(this.parentNode.parentElement);
                        elem.remove();
                        $(elem).appendTo(contentSelector);
                    });
                    break;
            }
        },
        output: function ($selector) {
            contentSelector = $selector;
        }
    }
}

// let bt1 = bugTracker();
// console.log(bt1.report('guy', 'report content', true, 5));
// console.log(bt1.report('second guy', 'report content 2', true, 3));