function solve(input) {
    let inputArr = input.split(/\W+/);

    for (let i = inputArr.length - 1; i >= 0 ; i--) {
        if (inputArr[i] == '') {
            inputArr.pop(inputArr[i]);
        }
    }

    for (let i = 0; i < inputArr.length; i++) {
        // console.log(inputArr[i].length + ": " + inputArr[i]);
        inputArr[i] = inputArr[i].toUpperCase();
    }

    console.log(inputArr.join(", "));
}

solve('Hi, how are you?');
// solve('\'hello\'');