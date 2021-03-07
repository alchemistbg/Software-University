function solve(input){
    //let arr = input
    for (let i = 0; i < input.length; i++) {
        if(input[i] == "Stop"){
            break;
        }else{
            console.log(input[i]);
        }
    }
}

solve(["Line 1",
    "Line 2",
    "Line 3",
    "Stop",
    "sdgffg"]);