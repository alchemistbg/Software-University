function solve(query) {
    let fruits = ["banana", "apple", "kiwi", "cherry", "lemon", "grapes", "peach"];
    let vegetables = ["tomato", "cucumber", "pepper", "onion", "garlic", "parsley"];

    if (fruits.includes(query)){
        console.log("fruit");
    }else if (vegetables.includes(query)){
        console.log("vegetable");
    }else{
        console.log("unknown");
    }
}

solve("banana");
solve("cucumber");
solve("pizza");
solve("dick");
