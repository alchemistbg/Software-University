function solve(totalInches) {
    let foots = Number.parseInt(totalInches / 12);
    let leftoverInches = totalInches % 12;
    console.log(`${foots}'-${leftoverInches}"`);
}

solve(36);
solve(55);
solve(11);