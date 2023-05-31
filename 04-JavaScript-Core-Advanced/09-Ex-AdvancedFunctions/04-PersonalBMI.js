function solve(name, age, weight, height) {
    let obj = {
        name: bookName,
        personalInfo: {
            age,
            weight,
            height
        },
        BMI: +calcBMI().toFixed(0),
        status: getStatus()
    };

    function calcBMI(){
            return weight/Math.pow((height/100), 2)
    };

    function getStatus(){
        if (calcBMI() < 18.5){
            return 'underweight';
        } else if (calcBMI() < 25){
            return 'normal';
        } else if (calcBMI() < 30){
            return 'overweight';
        } else {
            return 'obese';
        }
    };

    if (obj.status === 'obese'){
        obj['recommendation'] = 'admission required';
    }

    return obj;
}

console.log(solve('Peter', 29, 75, 182));
console.log(solve('Honey Boo Boo', 9, 57, 137));