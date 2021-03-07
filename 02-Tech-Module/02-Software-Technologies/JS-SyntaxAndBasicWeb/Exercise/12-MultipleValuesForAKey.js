function solve(input){
    let map = {};
    for(let i = 0; i < input.length - 1; i++){
        let key = input[i].split(" ")[0];
        let value = input[i].split(" ")[1];
        if(map[key] == undefined){
            map[key] = [];
        }
        map[key].push(value);
    }
    //console.log();
    if (map[input[input.length-1]] != undefined){
        for (let mapItem of map[input[input.length-1]]) {
            console.log(mapItem);
        }
    }else{
        console.log("None");
    }
}

solve([
    "key value",
    "key eulav",
    "test tset",
    "key"
]);
console.log("===========================");
solve([
    "3 test",
    "3 test1",
    "4 test2",
    "4 test3",
    "4 test5",
    "4"
]);
console.log("===========================");
solve([
    "3 bla",
    "3 alb",
    "2"
]);