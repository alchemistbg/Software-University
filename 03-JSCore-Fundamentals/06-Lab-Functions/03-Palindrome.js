function solve(str) {
    let strRev = str.split("").reverse().join("");
    console.log(str === strRev);
}

solve('haha');
solve('racecar');
solve('unitinu');