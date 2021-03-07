function solve(input){
    let jsonArr = [];
    for (let i = 0; i < input.length; i++) {
        let jsonObj = JSON.parse(input[i]);
        jsonArr.push(jsonObj);
    }

    for (let i = 0; i < jsonArr.length; i++) {
        console.log(`Name: ${jsonArr[i].name}`);
        console.log(`Age: ${jsonArr[i].age}`);
        console.log(`Date: ${jsonArr[i].date}`);
    }
}

solve([
    "{\"name\":\"Gosho\",\"age\":10,\"date\":\"19/06/2005\"}",
    "{\"name\":\"Tosho\",\"age\":11,\"date\":\"04/04/2005\"}"
]);