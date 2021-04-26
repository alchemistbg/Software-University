function solve(input) {
    let standing = [];

    for (let i = 0; i < input.length; i++) {
        let [teamName, pilotName, pilotPoints] = input[i].split(' -> ');
        let teamObj = {tName: teamName, tPoints: +pilotPoints, tPilots: [
                {
                    pName: pilotName,
                    pPoints: +pilotPoints
                }
            ]
        };

        let indexOuter = findWithAttr(standing, 'tName', teamName);
        if (indexOuter > -1){
            standing[indexOuter].tPoints += +pilotPoints;
            let pilotObj = {pName: pilotName, pPoints: +pilotPoints};

            let indexInner = findWithAttr(standing[indexOuter].tPilots, 'pName', pilotName);
            if (indexInner > -1){
                standing[indexOuter].tPilots[indexInner].pPoints += +pilotPoints;
            } else{
                standing[indexOuter].tPilots.push(pilotObj);
            }
        }else {
            standing.push(teamObj);
        }

        function findWithAttr(array, attr, value) {
            for(let i = 0; i < array.length; i += 1) {
                if(array[i][attr] === value) {
                    return i;
                }
            }
            return -1;
        }
    }

    for (let team of standing.sort((a, b) => b.tPoints - a.tPoints).slice(0, 3)) {
        console.log(`${team.tName}: ${team.tPoints}`);
        let sorted = team.tPilots.sort((a, b) => b.pPoints - a.pPoints);
        let keys = Object.keys(sorted);
        for (let i = 0; i < keys.length; i++) {
            console.log(`-- ${sorted[i].pName} -> ${sorted[i].pPoints}`)
        }
    }
}

/*solve([
    "Ferrari -> Kimi Raikonnen -> 25",
    "Ferrari -> Sebastian Vettel -> 18",
    "Mercedes -> Lewis Hamilton -> 10",
    "Mercedes -> Valteri Bottas -> 8",
    "Red Bull -> Max Verstapen -> 6",
    "Red Bull -> Daniel Ricciardo -> 4"
]);*/
console.log()
solve([
    'Ferrari -> Kimi Raikonnen -> 25',
    'Ferrari -> Sebastian Vettel -> 18',
    'Mercedes -> Lewis Hamilton -> 10',
    'Mercedes -> Valteri Bottas -> 8',
    'Red Bull -> Max Verstapen -> 6',
    'Red Bull -> Daniel Ricciardo -> 4',
    'Mercedes -> Lewis Hamilton -> 25',
    'Mercedes -> Valteri Bottas -> 18',
    'Haas -> Romain Grosjean -> 25',
    'Haas -> Kevin Magnussen -> 25'
]);