function solve(input){
    let regex = /([a-z!@#$?]+(?==))=((?<==)\d+)--((?<=--)\d+)<<((?<=<<)[a-z]+)/;

    let organisms = [];

    for (let line of input) {
        let matches = regex.exec(line);
        let orgArr = [];
        if (matches){
            let name = matches[1].replace(/[!@#$?]/g, '');
            let nameL = +matches[2];
            let genes = +matches[3];
            let organism = matches[4];
            orgArr.push(organism);
            if (name.length === nameL){
                let obj = {
                    n: name,
                    nL: nameL,
                    g: genes,
                    o: organism
                }
                let doesExist = organisms.some(x => orgArr.indexOf(x.o) !== -1);
                if (doesExist === true){
                    let index = findWithAttr(organisms, 'o', organism);
                    organisms[index].g += genes;
                } else {
                    organisms.push(obj);
                }
            }
        }
    }
    let sortedOrganisms = organisms.sort((a, b) => b.g - a.g);

    sortedOrganisms.forEach(
        x => console.log(`${x.o} has genome size of ${x.g}`)
    )

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
    '!@ab?si?di!a@=7--152<<human',
    'b!etu?la@=6--321<<dog',
    '!curtob@acter##ium$=14--230<<dog',
    '!some@thin@g##=9<<human',
    //'Stop!'
]);