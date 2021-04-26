function solve(input) {
    let gladiators = {};

    for (let iLine of input) {
        if (iLine.includes(' -> ')) {
            let [gladName, techName, skill] = iLine.split(' -> ');
            skill = +skill;

            if (!gladiators.hasOwnProperty(gladName)) {
                gladiators[gladName] = {};
                gladiators[gladName].totalSkill = 0;
                gladiators[gladName].techniques = {};
            }
            if (!gladiators[gladName].hasOwnProperty(techName)) {
                gladiators[gladName].techniques[techName] = skill;
            } else {
                if (gladiators[gladName].techniques[techName] < skill) {
                    gladiators[gladName].techniques[techName] = skill;
                }
            }
            gladiators[gladName]['totalSkill'] += skill;
        } else if (iLine.includes(' vs ')) {
            let [glad1, glad2] = iLine.split(' vs ');
            if (gladiators.hasOwnProperty(glad1) && gladiators.hasOwnProperty(glad2)) {
                let tech1 = Object.keys(gladiators[glad1].techniques);
                // console.log(gladiators[glad1].techniques)
                let tech2 = Object.keys(gladiators[glad2].techniques);

                //iterate over the array check element present in the second array
                let commonTech = tech1.filter(x => {
                    return tech2.indexOf(x) > -1; // or array2.includes(v);
                });
                if (commonTech.length > 0) {
                    if (gladiators[glad1].totalSkill > gladiators[glad2].totalSkill) {
                        delete gladiators[glad2];
                    } else if (gladiators[glad1].totalSkill < gladiators[glad2].totalSkill) {
                        delete gladiators[glad1];
                    }
                }
            }
        }
    }

    let sortedGlads = Object.keys(gladiators).sort((a, b) => {
        return gladiators[b].totalSkill - gladiators[a].totalSkill ||
            gladiators[a].localeCompare(gladiators[b]);
    });

    for (let sortedGlad of sortedGlads) {
        console.log(`${sortedGlad}: ${gladiators[sortedGlad].totalSkill} skill`);

        // console.log(gladiators[sortedGlad].techniques)
        let sortedTechs = Object.keys(gladiators[sortedGlad].techniques).sort((a, b) => {
            return gladiators[sortedGlad].techniques[b] - gladiators[sortedGlad].techniques[a] ||
               a.localeCompare(b);
        });
        //console.log(sortedTechs);

        for (let sortedTech of sortedTechs) {
            console.log(`- ${sortedTech} <!> ${gladiators[sortedGlad].techniques[sortedTech]}`)
        }
    }
}

/*solve([
    'Pesho -> BattleCry -> 400',
    'Pesho -> BattleCry -> 500', //added by me
    'Gosho -> PowerPunch -> 300',
    'Stamat -> Duck -> 200',
    'Stamat -> Buck -> 200', //added by me
    'Stamat -> Tiger -> 250',
    'Ave Cesar'
]);*/
// console.log();
solve([
    'Pesho -> Duck -> 400',
    'Julius -> Shield -> 150',
    'Gladius -> Heal -> 200',
    'Gladius -> Support -> 250',
    'Gladius -> Shield -> 250',
    //'Pesho vs Gladius',
    'Gladius vs Julius',
    //'Gladius vs Gosho',
    'Ave Cesar'
]);
