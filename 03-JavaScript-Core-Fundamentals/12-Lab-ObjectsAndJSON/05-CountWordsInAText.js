function solve(text) {
    let textArr = text[0].split(/\W+?/g).filter(x => x.length !== 0);

    let words = {};

    for (let i = 0; i < textArr.length; i++) {
        if (!Object.keys(words).includes(textArr[i])) {
            words[textArr[i]] = 1;
        } else {
            words[textArr[i]]++;
        }
    }
    console.log(JSON.stringify(words));
}

solve(['JS devs use Node.js for server-side JS.-- JS for devs']);
solve(['The man was walking the dog down the road when it suddenly started barking against the other dog. Surprised he pulled him away from it.']);