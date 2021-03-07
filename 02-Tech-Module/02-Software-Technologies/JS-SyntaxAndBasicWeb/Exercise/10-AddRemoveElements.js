function solve(input){
    let arr = [];
    for (let i = 0; i < input.length; i++){
        if (input[i].startsWith("add ")){
            arr.push(input[i].split(" ")[1]);
        } else{
            //console.log(input[i].split(" ")[1]);
            arr.splice(input[i].split(" ")[1], 1);
        }
    }

    for (let i = 0; i < arr.length; i++) {
        console.log(arr[i]);
    }
}

/*solve([
    "add 3",
    "add 5",
    "add 7"
]);*/

solve([
    "add 3",
    "add 5",
    "remove 1",
    "add 2"
]);