function solve(amInput, fInput) {
    let airMap = amInput.map(x => x.split(' ').map(Number));

    let forces = fInput;
    for (let i = 0; i < forces.length; i++) {
        let [force, value] = forces[i].split(' ');
        switch (force) {
            case 'breeze':
                airMap[+value] = airMap[+value].map(x => (x - 15) < 0 ? 0 : x - 15);
                //console.log(airMap)
                break;
            case 'gale':
                for (let j = 0; j < airMap.length; j++) {
                    //console.log(airMap[j][value])
                    airMap[j][+value] = (airMap[j][+value] - 20) < 0 ? 0 : airMap[j][+value] - 20;
                    //console.log(airMap[j][value])
                }
                //console.log(airMap);
                break;
            case 'smog':
                for (let j = 0; j < airMap.length; j++) {
                    airMap[j] = airMap[j].map(x => x + +value);
                }
        }
    }

    let poluted = [];
    for (let i = 0; i < airMap.length; i++) {
        for (let j = 0; j < airMap[i].length; j++) {
            if (airMap[i][j] >= 50){
                poluted.push(`[${i}-${j}]`);
            }
        }
    }

    if (poluted.length === 0){
        console.log('No polluted areas');
    }else {
        console.log(`Polluted areas: ${poluted.join(', ')}`)
    }
}

solve(
    [
        "5 7 72 14 4",
        "41 35 37 27 33",
        "23 16 27 42 12",
        "2 20 28 39 14",
        "16 34 31 10 24",
    ],
    ["breeze 1", "gale 2", "smog 25"]
);