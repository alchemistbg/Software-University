function solve(input) {
    let finalThickness = input[0];

    for (let i = 1; i < input.length; i++) {
        let currThickness = input[i];
        console.log(`Processing chunk ${currThickness} microns`);
        if (currThickness >= finalThickness * 4) {
            let cutResult = doCut(currThickness, finalThickness);
            currThickness = cutResult[0];
            console.log(`Cut x${cutResult[1]}`);
            currThickness = doTransportingAndWashing(currThickness)
        }

        if (currThickness >= finalThickness*1.2) {
            let lapResult = doLap(currThickness, finalThickness);
            currThickness = lapResult[0];
            console.log(`Lap x${lapResult[1]}`);
            currThickness = doTransportingAndWashing(currThickness)
        }

        if (currThickness >= finalThickness + 20) {
            let grindResult = doGrind(currThickness, finalThickness);
            currThickness = grindResult[0];
            console.log(`Grind x${grindResult[1]}`);
            currThickness = doTransportingAndWashing(currThickness);
        }

        if (currThickness > finalThickness) {
            let etchResult = doEtch(currThickness, finalThickness);
            currThickness = etchResult[0];
            console.log(`Etch x${etchResult[1]}`);
            currThickness = doTransportingAndWashing(currThickness);
        }

        if (currThickness < finalThickness) {
            let xrayResult = doXray(currThickness, finalThickness);
            currThickness = xrayResult[0];
            console.log(`X-ray x${xrayResult[1]}`);
            //currThickness = doTransportingAndWashing(currThickness)
        }
        console.log(`Finished crystal ${currThickness} microns`);
    }

    function doXray(current, final) {
        let counter = 0;
        while(current < final){
            counter++;
            current++;
        }
        return [current, counter];
    }
    
    function doEtch(current, final) {
        let counter = 0;
        while (current > final){
            counter++;
            current -= 2;
        }
        return [current, counter];
    }
    
    function doGrind(current, final) {
        let counter = 0;
        while (current - 20 >= final) {
            counter++;
            current -= 20;
        }
        return [current, counter];
    }

    function doLap(current, final) {
        let counter = 0;
        while (current - (current * 0.2) >= final) {
            counter++;
            current = current - (current * 0.2);
        }
        return [current, counter];
    }

    function doCut(current, final) {
        let counter = 0;
        while (current / 4 >= final) {
            current = current / 4;
            counter++;
        }
        return [current, counter];
    }

    function doTransportingAndWashing(current) {
        console.log('Transporting and washing');
        return Math.trunc(current)
    }
}

solve([1375, 50000]);
// solve([1000, 4000, 8100]);
//solve([1000, 8100]);