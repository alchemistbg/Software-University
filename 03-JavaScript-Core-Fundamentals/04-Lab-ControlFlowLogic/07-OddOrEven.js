function solve(num) {
    if(num % 2 == 0){
        console.log("even");
    }else if(Math.abs(num % 2) == 1){
        console.log("odd");
    }else{
        console.log("invalid");
    }
}

solve(5);
solve(8);
solve(1.5);