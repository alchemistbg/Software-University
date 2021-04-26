function solve(input) {
    let heroes = [];
    input.forEach(x => {
        let [name, level, itemsStr] = x.split(' / ');
        let items = [];
        if (itemsStr){
            items = itemsStr.split(', ');
        }

        let hero = {
            name: bookName,
            level: +level,
            items
        };
        heroes.push(hero);
    });

    console.log(JSON.stringify(heroes))
}

solve([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
]);