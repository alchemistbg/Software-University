function solve([speed, driveZone]){
    let message = calcOverSpeeding(speed, getSpeedLimit(driveZone));
    console.log(message);

    function getSpeedLimit(zone) {
        switch (zone) {
            case 'motorway': return 130;
            case 'interstate': return 90;
            case 'city': return 50;
            case 'residential': return 20;
        }
    }

    function calcOverSpeeding(speed, maxSpeed) {
        let overSpeeding = speed - maxSpeed;
        if (overSpeeding <= 0) {
            return '';
        } else if(overSpeeding <= 20) {
            return 'speeding';
        }else if (overSpeeding <= 40) {
            return 'excessive speeding';
        }else  {
            return 'reckless driving';
        }
    }
}

solve([40, 'city']);
solve([21, 'residential']);
solve([120, 'interstate']);
solve([200, 'motorway']);