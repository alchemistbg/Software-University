function solve(num) {
    let dna = 'ATCGTTAGGG';

    for (let i = 0; i < num; i++) {
        let fL = i * 2 % 10;
        let sL = (i * 2 + 1) % 10;

        let currentRow = i % 4;

        switch (currentRow) {
            case 0:
                console.log(`**${dna[fL]}${dna[sL]}**`);
                break;
            case 1:
            case 3:
                console.log(`*${dna[fL]}--${dna[sL]}*`);
                break;
            case 2:
                console.log(`${dna[fL]}----${dna[sL]}`);
                break;
        }
    }
}

solve(4);
console.log("----------------------");
solve(10);
console.log("----------------------");
solve(56);