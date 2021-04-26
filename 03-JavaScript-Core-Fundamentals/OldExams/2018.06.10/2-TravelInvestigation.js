function solve(input){
    let splitter = input[1];
    let companies = input[0].split(`${splitter}`);
    let valid = [];
    let invalid = [];

    for (let i = 2; i < input.length; i++) {
        let isValid = true;
        for (let j = 0; j < companies.length; j++) {
            if(!input[i].toLowerCase().includes(companies[j].toLowerCase())){
                isValid = false;
                break;
            }
        }
        if (isValid){
            valid.push(input[i]);
        }else{
            invalid.push(input[i]);
        }
    }

    if (valid.length){
        console.log('ValidSentences')
    }
    for (let i = 0; i < valid.length; i++) {
        console.log(`${i + 1}. ${valid[i].toLowerCase()}`)
    }
    if (invalid.length){
        if (valid.length){
            console.log('='.repeat(30));
        }
        console.log('InvalidSentences')
    }
    for (let i = 0; i < invalid.length; i++) {
        console.log(`${i + 1}. ${invalid[i].toLowerCase()}`)
    }
}

solve([
    "bulgariatour@, minkatrans@, koftipochivkaltd",
    "@,",
    "Mincho e KoftiPochivkaLTD Tip 123  ve MinkaTrans BulgariaTour",
    "dqdo mraz some text but is KoftiPochivkaLTD MinkaTrans",
    "someone continues as no "
]);