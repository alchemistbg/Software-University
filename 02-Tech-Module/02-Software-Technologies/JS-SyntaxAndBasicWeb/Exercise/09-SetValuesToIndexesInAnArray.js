function solve(input){
    let arrLength = Number(input[0]);
    let arr = [];
    arr.length = arrLength;
    for (let i = 1; i < input.length; i++) {
        let index = input[i].split(" - ")[0];
        let value = input[i].split(" - ")[1];
        arr[index] = value;
    }

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] == undefined){
            arr[i] = 0;
        }
        console.log(arr[i]);
    }
}

solve([
    "5",
    "0 - 3",
    "3 - -1",
    "4 - 2"
]);