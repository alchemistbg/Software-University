function solve(input) {
    let gladiators = [];


    let gTech;
    for (let iLine of input) {
        if (iLine.includes(' -> ')) {
            let iLineArr = iLine.split(' -> ');
            let gName = iLineArr[0];
            let gTotalSkills = 0;
            gTech = iLineArr[1];
            let gSkill = +iLineArr[2];

            let gladIndex = findWithAttr(gladiators, 'gName', gName);
            if (gladIndex > -1) {
                let techIndex = findWithAttr(gladiators[gladIndex].tech, 'gTech', gTech);
                if (techIndex > -1) {
                    if (gladiators[gladIndex].tech[techIndex].gSkill < gSkill) {
                        gladiators[gladIndex].gTotalSkills += (gSkill - gladiators[gladIndex].tech[techIndex].gSkill)
                        gladiators[gladIndex].tech[techIndex].gSkill = gSkill;
                    }
                } else {
                    let techObj = {
                        gTech,
                        gSkill
                    };
                    gladiators[gladIndex].tech.push(techObj);
                    gladiators[gladIndex].gTotalSkills += gSkill;
                }

            } else {
                gTotalSkills = gSkill;
                let gladObj = {
                    gName,
                    gTotalSkills,
                    tech: [
                        {
                            gTech,
                            gSkill
                        }
                    ]
                };

                gladiators.push(gladObj);
            }
        } else if (iLine.includes(' vs ')) {
            let [gladiator1, gladiator2] = iLine.split(' vs ');

            let glad1Index = findWithAttr(gladiators, 'gName', gladiator1);
            let glad2Index = findWithAttr(gladiators, 'gName', gladiator2);
            if (glad1Index > -1 && glad2Index > -1) {

                let tech1 = [];
                gladiators[glad1Index].tech.forEach(x => tech1.push(x.gTech));
                let tech2 = [];
                gladiators[glad2Index].tech.forEach(x => tech2.push(x.gTech));

                //iterate over the array check element present in the second array
                let commonTech = tech1.filter(x => {
                   return tech2.indexOf(x) > -1; // or array2.includes(v);
                });
                if (commonTech.length > 0) {
                    if (gladiators[glad1Index].gTotalSkills > gladiators[glad2Index].gTotalSkills) {
                        gladiators.splice(glad2Index, 1);
                    } else if (gladiators[glad1Index].gTotalSkills < gladiators[glad2Index].gTotalSkills) {
                        gladiators.splice(glad1Index, 1);
                    }
                }
            }
        }
    }

    gladiators
        .sort(
            (a, b) => {
                return (b.gTotalSkills - a.gTotalSkills) || (a.gName > b.gName);
            })
        .forEach(
            (x) => {
                x.tech.sort((a, b) => {
                    return (b.gSkill - a.gSkill) || (a.gTech > b.gTech);
                });
            }
        );

    /*gladiators.forEach((x) => {
        console.log(`${x.gName}: ${x.gTotalSkills} skill`);
        x.tech.forEach((y) => {
            console.log(`- ${y.gTech} <!> ${y.gSkill}`)
        })
    });*/
    console.log(gladiators[0].gName);

    function findWithAttr(array, attr, value) {
        for (let i = 0; i < array.length; i += 1) {
            if (array[i][attr] === value) {
                return i;
            }
        }
        return -1;
    }
}

solve([
    'Pesho -> BattleCry -> 400',
    'Pesho -> BattleCry -> 500', //added by me
    'Gosho -> PowerPunch -> 300',
    'Stamat -> Duck -> 200',
    'Stamat -> Buck -> 200', //added by me
    'Stamat -> Tiger -> 250',
    'Ave Cesar'
]);
console.log();
solve([
    'Pesho -> Duck -> 400',
    'Julius -> Shield -> 150',
    'Gladius -> Heal -> 200',
    'Gladius -> Support -> 250',
    'Gladius -> Shield -> 250',
    'Pesho vs Gladius',
    'Gladius vs Julius',
    'Gladius vs Gosho',
    'Ave Cesar'
]);