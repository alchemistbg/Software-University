function solve([number, precision]){
    let dNumber = number.toString().split(".")[1];

    if (dNumber === undefined) {
        precision = 0;
    }else{
        if (precision > dNumber.length) {
            precision = dNumber.length;
        }
        if (precision > 15) {
            precision = 15;
        }
    }
    console.log(number.toFixed(precision));
}

solve([3.1415926535897932384626433832795, 2]);
solve([10.5, 3]);
solve([10, 3]);