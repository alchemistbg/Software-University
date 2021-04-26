function solve(grads) {
    grads = grads % 400;
    if (grads < 0){
        grads = 400 + grads;
    }

    let deg = grads*0.9;
    console.log(deg);
}

solve(100)
solve(400)
solve(850)
solve(-50)
solve(0)