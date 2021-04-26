function solve(input) {
    let systems = [];
    for (let iLine of input) {
        let [sysName, compName, subCompName] = iLine.split(' | ');

        let sysIndex = findWithAttr(systems, 'sysName', sysName);
        if (sysIndex > -1){
            let compIndex = findWithAttr(systems[sysIndex].components, 'compName', compName);
            if (compIndex > -1){
                systems[sysIndex].components[compIndex].subComponents.push(subCompName);
            } else {
                let compObj = {
                    compName,
                    subComponents: [
                        subCompName
                    ]
                };
                systems[sysIndex].components.push(compObj);
            }
        } else {
            let sysObj = {
                sysName,
                components: [
                    {
                        compName,
                        subComponents: [
                            subCompName
                        ]
                    }
                ]
            };
            systems.push(sysObj);
        }
    }

    let sortedSystems = systems.sort((a, b) => {
        if (a.components.length < b.components.length){
            return 1;
        }
        else if (a.components.length > b.components.length){
            return -1;
        } else {
            if (a.sysName > b.sysName){
                return 1;
            } else if (a.sysName < b.sysName) {
                return -1;
            } else {
                return 0
            }
        }
    });

    for (let sortedSystem of sortedSystems) {
        console.log(`${sortedSystem.sysName}`);
        sortedSystem.components.sort((a, b) => b.subComponents.length - a.subComponents.length);
        for (let i = 0; i < sortedSystem.components.length; i++) {
            console.log(`|||${sortedSystem.components[i].compName}`)
            for (let j = 0; j < sortedSystem.components[i].subComponents.length; j++) {
                console.log(`||||||${sortedSystem.components[i].subComponents[j]}`);
            }
        }
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

solve([
    'SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    //'Lambda | CoreD | A2t5', //addedByMe
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security'
]);