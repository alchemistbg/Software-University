function attachEventsListeners() {
    document.getElementById('daysBtn').addEventListener('click', () => {
        let daysNum = +document.getElementById('days').value;
        document.getElementById('hours').value = daysNum * 24;
        document.getElementById('minutes').value = daysNum * 24 * 60;
        document.getElementById('seconds').value = daysNum * 24 * 60 * 60;
    });

    document.getElementById('hoursBtn').addEventListener('click', () => {
        let hoursNum = +document.getElementById('hours').value;
        document.getElementById('days').value = hoursNum / 24;
        document.getElementById('minutes').value = hoursNum * 60;
        document.getElementById('seconds').value = hoursNum * 60 * 60;
    });

    document.getElementById('minutesBtn').addEventListener('click', () => {
        let minutesNum = +document.getElementById('minutes').value;
        document.getElementById('days').value = minutesNum / 60 / 24;
        document.getElementById('hours').value = minutesNum / 60;
        document.getElementById('seconds').value = minutesNum * 60;
    });

    document.getElementById('secondsBtn').addEventListener('click', () => {
        let secondsNum = +document.getElementById('seconds').value;
        document.getElementById('days').value = secondsNum / 24 / 60 / 60;
        document.getElementById('hours').value = secondsNum / 60 / 60;
        document.getElementById('minutes').value = secondsNum / 60;
    });
}