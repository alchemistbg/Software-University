function solve(treshold, name1, age1, name2, age2){
    let objArr = [];
    let obj1 = {};
    obj1.name = name1;
    obj1.age = Number(age1);
    let obj2 = {};
    obj2.name = name2;
    obj2.age = Number(age2);
    objArr.push(obj1);
    objArr.push(obj2);
    for (let i = 0; i <= objArr.length; i++) {
        if (Number(treshold) < objArr[i].age){
            console.log(objArr[i]);
        }
    }
}

solve(12, "Ivan", 15, "Asen", 9);