function solve(input) {
    let start = +input[0];
    let end = +input[1] + 1;
    let replacement = input[2];
    let countryRegex = /[A-Z][a-z]*[A-Z]/g;
    let foundCountries = input[3].match(countryRegex);

    let country = '';
    for (let item of foundCountries) {
        let sub = item.substring(start, end);
        if (sub[sub.length - 1] !== sub[sub.length - 1].toUpperCase()){
            country = item.replace(sub, replacement);
        }
    }
    country = country[0].toUpperCase() + country.slice(1).toLowerCase();

    let cityChars = [];
    let city = ''
    let numberRegex = /[\d]{3}[.\d]*/g;
    let foundNumbers = input[3].match(numberRegex);
    for (let i = 0; i < foundNumbers.length; i++){
        if (i === 0){
            city += String.fromCharCode(Math.ceil(+foundNumbers[i])).toUpperCase();
        }else {
            city += String.fromCharCode(Math.ceil(+foundNumbers[i])).toLowerCase();
        }
    }

    console.log(`${country} => ${city}`)
}
solve([
    "3",
    "5",
    "gar",
    "114 sDfia 1, riDl10 confin$4%#ed117 likewise it" +
    "humanity aTe114.223432 BultoriA - Varnd railLery101 an unpacked as he"]);
solve([
    "1",
    "4",
    "loveni",
    "SerbiA 67 – sDf1d17ia aTe 1, 108 confin$4%#ed likewise it" +
        "humanity  Bulg35aria - VarnA railLery1a0s1 111 an unpacked as 109 he"]);