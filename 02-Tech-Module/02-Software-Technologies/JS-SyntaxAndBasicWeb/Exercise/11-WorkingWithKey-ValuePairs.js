function solve(input){
    let map = {};
    for(let i = 0; i < input.length - 1; i++){
        let key = input[i].split(" ")[0];
        let value = input[i].split(" ")[1];
        map[key] = value;
    }
    //console.log();
    if (map[input[input.length-1]] != undefined){
        console.log(map[input[input.length-1]]);
    }else{
        console.log("None");
    }
}

/*
solve([
    "key value",
    "key eulav",
    "test tset",
    "key"
]);*/

/*
solve([
    "3 test",
    "3 test1",
    "4 test2",
    "4 test3",
    "4 test5",
    "4"
]);*/

solve([
    "3 bla",
    "3 alb",
    "2"
]);