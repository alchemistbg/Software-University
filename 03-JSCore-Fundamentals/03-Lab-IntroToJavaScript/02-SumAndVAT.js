function solve(input){
    let sum = 0;
    for (let i = 0; i < input.length; i++) {
        sum += input[i];
    }
    let vat = sum*0.2;
    console.log(`sum = ${sum}`);
    console.log(`vat = ${vat}`);
    console.log(`total = ${sum + vat}`);
    //console.log(`total = ${(sum + vat).toFixed(2)}`);
}

solve([1.20, 2.60, 3.50]);
console.log("=================================");
solve([3.12, 5, 18, 19.24, 1953.2262, 0.001564, 1.1445]);