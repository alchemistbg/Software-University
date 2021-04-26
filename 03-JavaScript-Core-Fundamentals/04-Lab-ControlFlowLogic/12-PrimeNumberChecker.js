function solve(num) {
    let isPrime = true;
    if(num < 2){
        isPrime = false;
        //break;
    }else {
        for (let i = 2; i <= Math.sqrt(num); i++) {
            if (num % i == 0) {
                isPrime = false;
                //break;
            }
        }
    }
    console.log(isPrime);
}

solve(7);
solve(8);
solve(81);
solve(99991);
