function solve(query, str) {
    let count = 0;
    //solution from lecture presentation
    let index = str.indexOf(query);
    while(index > -1){
        count++;
        index = str.indexOf(query, index + 1)
    }

    //mine solution - it also get 100/100
    /*let qLength = query.length;
    for (let i = 0; i < str.length; i++) {
        let s = str.slice(i, i + qLength);
        if (s === query) {
            count++;
        }
    }*/

    console.log(count);
}

solve('the', 'The quick brown fox jumps over the lay dog.');
console.log();
solve('ma', 'Marine mammal training is the training and caring for marine life such as, dolphins, killer whales, sea lions, walruses, and other marine mammals. It is also obj1 duty of the trainer to do mental and physical exercises to keep the animal healthy and happy.');