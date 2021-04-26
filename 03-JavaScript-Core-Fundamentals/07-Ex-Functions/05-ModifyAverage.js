function solve(num) {

    let average = calcAverage(num + "");
    while (average <= 5){
        num = num + "9";
        average = calcAverage(num);
    }

    console.log(num);
    function calcAverage(num) {
        let arr = num.split("").map(Number);
        let average = 0;
        for (let i = 0; i < arr.length; i++) {
            average += arr[i];
        }
        average = average/arr.length;
        return average;
    }
}

solve(101);
solve(5835);
// solve(101999);