function solve(year) {
    let isLeap = false;
    if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)){
        isLeap = true;
    }
    if(isLeap){
        console.log("yes");
    }else{
        console.log("no");
    }
}

solve(1999);
solve(2000);
solve(1900);