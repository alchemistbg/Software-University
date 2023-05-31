function gcd(a, b){
    if (b === 0){
        return a;
    } else {
        return gcd (b, a % b);
    }
}

console.log(gcd(252, 105));
console.log(gcd(4, 6));
// console.log(gcd(6, 4));