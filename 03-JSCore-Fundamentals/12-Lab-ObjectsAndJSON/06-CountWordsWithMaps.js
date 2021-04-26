function solve(text) {
    let textArr = text[0].split(/\W+?/g).filter(x => x.length !== 0).map(x => x.toLowerCase()).sort();

    let words = {};

    for (let i = 0; i < textArr.length; i++) {
        if (!Object.keys(words).includes(textArr[i])) {
            words[textArr[i]] = 1;
        } else {
            words[textArr[i]]++;
        }
    }

    let ent = Object.entries(words);
    ent.forEach((word, index, ent) => {
        console.log(`'${ent[index][0]}' -> ${ent[index][1]} times`)
    });
    //console.log(JSON.stringify(words));
}

solve(['Far too slow, you\'re far too slow.']);
solve(['JS devs use Node.js for server-side JS.-- JS for devs']);
// solve(['The man was walking the dog down the road when it suddenly started barking against the other dog. Surprised he pulled him away from it.']);