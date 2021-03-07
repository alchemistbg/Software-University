function solve(input) {
    let arr = input.map(Number);

    let countnegatives = 0;
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] < 0){
            countnegatives++;
        }
    }

    if (countnegatives == 2 || countnegatives == 0){
        console.log("Positive");
    }else{
        console.log("Negative");
    }
}

solve(["2", "3", "-1"]);