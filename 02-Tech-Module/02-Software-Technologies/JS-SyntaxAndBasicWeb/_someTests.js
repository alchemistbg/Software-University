function solve(){
    let arr = [];

    arr.push(3)
    arr.push(7)
    arr.pop(1);
    arr.push(1)


    for (let i = 0; i < arr.length; i++) {
        console.log(arr[i]);
    }
}

solve();

/*
function solve(){
    let result = "";
    for (let i = 1; i < 100; i++) {
        if (i % 15 == 0){
            result = `${i} -> ` + "FizzBuzz";
        }else if(i % 5 == 0){
            result = `${i} -> ` + "Buzz";
        }else if(i % 3 == 0){
            result = `${i} -> ` + "Fizz";
        }else{
            result = `${i}`;
        }
        console.log(result);
    }
}

solve();*/
