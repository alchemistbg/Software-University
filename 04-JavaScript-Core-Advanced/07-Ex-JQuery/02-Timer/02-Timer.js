function timer() {
    let $sec = 0;
    let timer;
    //let $hours = $('#hours');
    let $start = $('#start-timer').on('click', () => {
        clearInterval(timer);
        timer = setInterval(() => {
            $sec++;
            setTime($sec);
        }, 1000);
    });

    let $pause = $('#stop-timer').on('click', () => {
        clearInterval(timer);
    });

    let setTime = function (sec) {
        let hoursStr, minStr, secStr;
        let hours = Math.trunc(sec / 60 / 60);
        let minutes = Math.trunc((sec - (hours * 3600)) / 60);
        let seconds = sec % 60;
        if (hours >= 0 && hours < 10) {
            hoursStr = '0' + hours;
        } else {
            hoursStr = '' + hours;
        }
        $('#hours').text(hoursStr);

        if (minutes >= 0 && minutes < 10){
            minStr = '0' + minutes;
        } else {
            minStr = minutes;
        }
        $('#minutes').text(minStr);

        if (seconds >= 0 && seconds < 10){
            secStr = '0' + seconds;
        } else {
            secStr = seconds;
        }
        $('#seconds').text(secStr);
    }
}