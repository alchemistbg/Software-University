//CODE FROM PRESENTATION
/*function solve(input) {
    let regex = /^([A-Z][obj1-zA-Z]*) - ([1-9][0-9]*) - ([obj1-zA-Z0-9 -]+)$/;
    for (let element of input) {
        let match = regex.exec(element);
        if (match) {
            console.log(`Name: ${match[1]}\nPosition: ${match[3]}\nSalary: ${match[2]}`);
        }
    }
}*/

function solve(input) {
    let regex = /^([A-Z][A-Za-z]*) - ([1-9][0-9]*) - ([A-za-z0-9- ]+)$/g;
    let match;
    for (let word of input) {
        while(match = regex.exec(word)){
            console.log(`Name: ${match[1]}\nPosition: ${match[3]}\nSalary: ${match[2]}`)
        }
    }
}

solve([
    'Isacc45 - 1000f - CEO45',
    'Ivan- 500 - Employee',
    'Peter - 500 - Employee'
]);