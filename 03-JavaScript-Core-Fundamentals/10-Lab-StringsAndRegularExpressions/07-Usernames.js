/*
function solve(input) {
    let result = [];
    for (let i = 0; i < input.length; i++) {
        let fSplit = input[i].split('@');
        let sSplit = fSplit[1].split('.');
        let str = '';
        for (let j = 0; j < sSplit.length; j++) {
            str += sSplit[j].substr(0, 1);
        }
        result.push(`${fSplit[0]}.${str}`);
    }
    console.log(result.join(', '));
}

solve(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);*/

let strArr = ['12', '13', '14','25'];
for (let i in strArr) {
    strArr[i] = +strArr[i];
}
let a = strArr.reduce((a, b) => a*b);
console.log(strArr);
console.log(a);