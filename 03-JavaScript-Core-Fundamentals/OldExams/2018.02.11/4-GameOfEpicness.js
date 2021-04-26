function solve(iArmies, iBattles) {
    let kingdoms = {};
    for (let iArmy of iArmies) {
        let kingdom = iArmy.kingdom;
        let general = iArmy.general;
        let army = +iArmy.army;

        if (!kingdoms.hasOwnProperty(kingdom)) {
            kingdoms[kingdom] = {};
            kingdoms[kingdom].bookName = kingdom;
            kingdoms[kingdom].generals = {};
            kingdoms[kingdom].totWins = 0;
            kingdoms[kingdom].totLosses = 0;

        }
        if (!kingdoms[kingdom].generals.hasOwnProperty(general)) {
            kingdoms[kingdom].generals[general] = {};
            kingdoms[kingdom].generals[general].bookName = general;
            kingdoms[kingdom].generals[general].army = 0;
        }
        kingdoms[kingdom]['generals'][general].army += army;
        kingdoms[kingdom]['generals'][general].wins = 0;
        kingdoms[kingdom]['generals'][general].losses = 0;
    }

    for (let iBattle of iBattles) {
        let [attKingdom, attGeneral, defKingdom, defGeneral] = [...iBattle];
        
        if (attKingdom !== defKingdom){
            if (kingdoms[attKingdom].generals[attGeneral].army > kingdoms[defKingdom].generals[defGeneral].army){
                doBattle(attKingdom, attGeneral, defKingdom, defGeneral);
            }else if(kingdoms[attKingdom].generals[attGeneral].army < kingdoms[defKingdom].generals[defGeneral].army){
                doBattle(defKingdom, defGeneral, attKingdom, attGeneral);
            }
        }
    }
    function doBattle(fKingdom, fGen, sKingdom, sGen) {
        kingdoms[fKingdom].generals[fGen].army =
            Math.floor(kingdoms[fKingdom].generals[fGen].army *= 1.1);
            //Math.floor(fArmy * 1.1);
        kingdoms[fKingdom].totWins ++;
        kingdoms[fKingdom].generals[fGen].wins ++;
        kingdoms[sKingdom].generals[sGen].army =
            Math.floor(kingdoms[sKingdom].generals[sGen].army *= 0.9);
            //Math.floor(sArmy * 0.9);
        kingdoms[sKingdom].totLosses ++;
        kingdoms[sKingdom].generals[sGen].losses ++;
    }

    let winner = Object.values(kingdoms).sort((a, b) =>
        b.totWins - a.totWins ||
        a.totLosses - b.totLosses ||
        a.bookName > b.bookName
    )[0];

    let winnerGenerals = Object.keys(winner.generals).sort((a, b) =>
        winner.generals[b].army - winner.generals[a].army
    );
    console.log(`Winner: ${winner.bookName}`);
    for (let winnerGeneral of winnerGenerals) {
        console.log(`/\\general: ${kingdoms[winner.bookName].generals[winnerGeneral].bookName}`)
        console.log(`---army: ${kingdoms[winner.bookName].generals[winnerGeneral].army}`)
        console.log(`---wins: ${kingdoms[winner.bookName].generals[winnerGeneral].wins}`)
        console.log(`---losses: ${kingdoms[winner.bookName].generals[winnerGeneral].losses}`)
    }
}

solve(
    [
        {kingdom: "Maiden Way", general: "Merek", army: 5000},
        {kingdom: "Stonegate", general: "Ulric", army: 4900},
        {kingdom: "Stonegate", general: "Doran", army: 70000},
        {kingdom: "YorkenShire", general: "Quinn", army: 0},
        {kingdom: "YorkenShire", general: "Quinn", army: 2000},
        {kingdom: "Maiden Way", general: "Berinon", army: 100000}
    ],
    [
        ["YorkenShire", "Quinn", "Stonegate", "Ulric"],
        ["Stonegate", "Ulric", "Stonegate", "Doran"],
        ["Stonegate", "Doran", "Maiden Way", "Merek"],
        ["Stonegate", "Ulric", "Maiden Way", "Merek"],
        ["Maiden Way", "Berinon", "Stonegate", "Ulric"]
    ]
);
console.log();
/*
solve(
    [
        {kingdom: "Stonegate", general: "Ulric", army: 5000},
        {kingdom: "YorkenShire", general: "Quinn", army: 5000},
        {kingdom: "Maiden Way", general: "Berinon", army: 1000}
    ],
    [
        ["YorkenShire", "Quinn", "Stonegate", "Ulric"],
        ["Maiden Way", "Berinon", "YorkenShire", "Quinn"]
    ]
);*/
