function solve(num) {
    for (let i = 1; i <= num; i++) {
        let strOrig = i.toString();
        let strRev = strOrig.split("").reverse().join("");
        if(strOrig == strRev){
            console.log(strOrig);
        }
    }
}
    
solve(750);