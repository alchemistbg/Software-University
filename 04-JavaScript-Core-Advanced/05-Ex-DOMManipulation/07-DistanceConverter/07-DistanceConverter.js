function attachEventsListeners() {
    document.getElementById('convert').addEventListener('click', () => {
        let distances = {
            km: 1000,
            m: 1,
            cm: 0.01,
            mm: 0.001,
            mi: 1609.34,
            yrd: 0.9144,
            ft: 0.3048,
            in: 0.0254
        };

        let number = +document.getElementById('inputDistance').value;
        let selectedInput = document.getElementById('inputUnits').value;
        let selectedOutput = document.getElementById('outputUnits').value;

        let result = number * distances[selectedInput] / distances[selectedOutput];
        document.getElementById('outputDistance').value = result;
    });
}