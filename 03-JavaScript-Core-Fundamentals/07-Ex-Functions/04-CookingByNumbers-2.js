function solve(arr) {
    let [num, op1, op2, op3, op4, op5] = [+arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]];

    let cookingNumber = num;
    let chop = num => num / 2;
    let dice = num => Math.sqrt(num);
    let spice = num => num + 1;
    let bake = num => num * 3;
    let fillet = num => num * 0.8;

    for (let op of [op1,op2,op3,op4,op5]) {
        switch (op) {
            case 'chop': cookingNumber = chop(cookingNumber);
                console.log(cookingNumber);
                break;
            case 'dice': cookingNumber = dice(cookingNumber);
                console.log(cookingNumber);
                break;
            case 'spice': cookingNumber = spice(cookingNumber);
                console.log(cookingNumber);
                break;
            case 'bake': cookingNumber = bake(cookingNumber);
                console.log(cookingNumber);
                break;
            case 'fillet': cookingNumber = fillet(cookingNumber);
                console.log(cookingNumber);
                break;
        }
    }
}

solve([32, 'chop', 'chop', 'chop', 'chop', 'chop']);
solve([9, 'dice', 'spice', 'chop', 'bake', 'fillet']);