function solve(input) {
    let towns = [];
    for (let line of input.slice(1)) {
        let [t, lat, lng] = line.split(/\s*\|\s*/g).slice(1);
        let town = {Town: t, Latitude: +lat, Longitude: +lng};
        towns.push(town);
    }

    console.log(JSON.stringify(towns));
}

solve(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']
);