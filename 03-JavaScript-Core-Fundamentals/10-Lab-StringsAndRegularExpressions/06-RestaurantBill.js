function solve(input) {
    let orderedProducts = [];
    let totalPrice = 0;
    for (let i = 0; i < input.length; i+=2) {
        orderedProducts.push(input[i]);
        totalPrice += +input[i+1];
    }
    console.log(`You purchased ${orderedProducts.join(', ')} for a total sum of ${totalPrice}`);
}

solve(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);
console.log();
solve(['Cola', '1.35', 'Pancakes', '2.88']);