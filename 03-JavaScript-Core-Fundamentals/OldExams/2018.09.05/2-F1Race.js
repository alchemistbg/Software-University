function solve(input) {
    let standing = input[0].split(' ').filter(x => x.length !==0);
    //console.log(standing.join(' ~ '));
    for (let i = 1; i < input.length; i++) {
        let row = input[i].split(' ').filter(x => x.length !==0);
        let event = row[0];
        let pilot = row[1];

        if (event.toUpperCase() === 'JOIN' && !standing.includes(pilot)) {
            standing.push(pilot);
        }

        if (event.toUpperCase() === 'CRASH' && standing.includes(pilot)) {
            standing.splice(standing.indexOf(pilot), 1);
        }

        if(event.toUpperCase() === 'OVERTAKE' && standing.includes(pilot) && standing.indexOf(pilot) > 0){
            let overtakingPilotIndex = standing.indexOf(pilot);
            let temp = standing[overtakingPilotIndex - 1];
            standing[overtakingPilotIndex - 1] = pilot;
            standing[overtakingPilotIndex] = temp;
        }

        if (event.toUpperCase() === 'PIT' && standing.includes((pilot))) {
            let pitPilotIndex = standing.indexOf(pilot);
            let temp = standing[pitPilotIndex];
            standing[pitPilotIndex] = standing[pitPilotIndex + 1];
            standing[pitPilotIndex + 1] = temp;
        }
    }
    console.log(standing.join(' ~ '));
}

solve([
    "Vetel Hamilton Slavi",
    "Pit Hamilton",
    "Overtake Vetel",
    "Crash Slavi"
]);
/*console.log();
solve([
    "Vetel Hamilton Raikonnen Botas Slavi",
    "Pit Hamilton",
    "Overtake   LeClerc",
    "Join Ricardo",
    "Crash Botas",
    "Overtake Ricardo",
    "Overtake Ricardo",
    "Overtake Ricardo",
    "Crash Slavi"
]);*/
