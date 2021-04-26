function solve(input){
    let uNames = new Set();
    for (let uName of input) {
        uNames.add(uName);
    }
    let uNamesArr = Array.from(uNames);
    uNamesArr.sort((a, b) => {
        if (a.length > b.length){
            return 1;
        } else if (a.length < b.length){
            return -1;
        } else {
            if (a > b){
                return 1;
            } else if(a < b){
                return -1;
            }else{
                return 0;
            }
        }
    });
    console.log(uNamesArr.join('\n'))
}

solve([
    'Ashton',
    'Kutcher',
    'Ariel',
    'Lilly',
    'Keyden',
    'Aizen',
    'Billy',
    'Braston'
]);
console.log();
solve([
    'Denise',
    'Ignatius',
    'Iris',
    'Isacc',
    'Indie',
    'Dean',
    'Donatello',
    'Enfuego',
    'Benjamin',
    'Biser',
    'Bounty',
    'Renard',
    'Rot'
    ]);