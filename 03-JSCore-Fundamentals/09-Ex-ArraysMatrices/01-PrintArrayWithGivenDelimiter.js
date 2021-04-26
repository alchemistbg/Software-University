function solve(arr){
    let delim = arr.pop();
    console.log(arr.join(delim));
}

solve(['One', 'Two', 'Three', 'Four', 'Five', '-']);