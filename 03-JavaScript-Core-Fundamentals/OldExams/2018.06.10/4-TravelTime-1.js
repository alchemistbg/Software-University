function solve(input) {
    let countries = [];
    for (let iLine of input) {
        let iLineArr = iLine.split(' > ');
        let cName = iLineArr[0];
        let tName = iLineArr[1][0].toUpperCase() + iLineArr[1].slice(1);
        let tCost = +iLineArr[2];

        let cIndex = findWithAttr(countries, 'cName', cName);
        if (cIndex > -1) {
            let tIndex =  findWithAttr(countries[cIndex].towns, 'tName', tName);
            if (tIndex > -1){
                if (countries[cIndex].towns[tIndex].tCost > tCost){
                    countries[cIndex].towns[tIndex].tCost = tCost;
                }
            } else {
                let tObj = {
                    tName,
                    tCost
                };
                countries[cIndex].towns.push(tObj);
            }
        } else {
            let cObj = {
                cName,
                towns: [
                    {
                        tName,
                        tCost
                    }
                ]
            }
            countries.push(cObj);
        }
    }

    let sortedCountries = countries.sort((a, b) => {
        return a.cName.localeCompare(b.cName);
    });

    sortedCountries.forEach(x => {
        let cLog = x.cName + ' -> ';
        x.towns.sort((a, b) => {
            return a.tCost - b.tCost;
        });
        x.towns.forEach(y => {
            cLog += `${y.tName} -> ${y.tCost} `;
        });
        console.log(cLog.trim());
    });

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
    "Bulgaria > Sofia > 500",
    "Bulgaria > Sopot > 800",
    "Bulgaria > sopot > 500", //added
    "France > Paris > 2000",
    "Albania > Tirana > 1000",
    "Bulgaria > Sofia > 200"
]);
console.log();
solve([
    'Bulgaria > Sofia > 25000',
    'aaa > Sofia > 1',
    'aa > Orgrimar > 0',
    'Albania > Tirana > 25000',
    'zz > Aarna > 25010',
    'Bulgaria > Lukovit > 10'
]);