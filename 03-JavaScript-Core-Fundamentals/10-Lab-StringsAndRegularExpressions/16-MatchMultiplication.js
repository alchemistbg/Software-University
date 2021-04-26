//100/100
/*function solve(str) {
    function replacer(match, p1, p2) {
        return p1*p2;
    }
    str = str.replace(/(-?\d+?)\s*\*\s*(-?\d*.\d*)/g, replacer);
    console.log(str);
}*/

function solve(str) {
    str = str.replace(/(-?\d+?)\s*\*\s*(-?\d*.\d*)/g, (match, n1, n2) => Number(n1) * Number(n2));
    console.log(str);
}

solve('My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit).');//