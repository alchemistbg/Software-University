function solve(input) {
    let peachMass = 0;
    let plumMass = 0;
    let cherryMass = 0;
    let otherMass = 0;
    for (let i = 0; i < input.length; i++) {
        if (input[i].toUpperCase().startsWith('peach '.toUpperCase())) {
            peachMass += +input[i].split(' ').filter(x => x.length !== 0)[1];
        } else if (input[i].toUpperCase().startsWith('plum '.toUpperCase())) {
            plumMass += +input[i].split(' ').filter(x => x.length !== 0)[1];
        } else if (input[i].toUpperCase().startsWith('cherry '.toUpperCase())) {
            cherryMass += +input[i].split(' ').filter(x => x.length !== 0)[1];
        } else {
            otherMass += +input[i].split(' ').filter(x => x.length !== 0)[1];
        }
    }

    let cherryKompot = Math.trunc(cherryMass * 1000 / 9 / 25);
    let peachKompot = Math.trunc(peachMass * 1000 / 140 / 2.5);
    let plumKompot = Math.trunc(plumMass * 1000 / 20 / 10);
    let rakiya = (otherMass * 0.2).toFixed(2);

    console.log(`Cherry kompots: ${cherryKompot}`);
    console.log(`Peach kompots: ${peachKompot}`);
    console.log(`Plum kompots: ${plumKompot}`);
    console.log(`Rakiya liters: ${rakiya}`);
}

solve([
    'cherry   1.2',
    'peach 2.2',
    'plum 5.2',
    'peach 0.1',
    'cherry 0.2',
    'cherry 5.0',
    'plum 10',
    'cherry 20.0',
    'papaya 20'
]);
console.log();
solve([
    'apple 6',
    'peach 25.158',
    'strawberry 0.200',
    'peach 0.1',
    'banana 1.55',
    'cherry 20.5',
    'banana 16.8',
    'grapes 205.65',
    'watermelon 20.54'
]);