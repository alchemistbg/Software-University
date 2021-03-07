function solve(input){
    let obj = {};
    let name = input[0].split(" -> ")[1];
    obj.name = name;
    let surname = input[1].split(" -> ")[1];
    obj.surname = surname;
    let age = Number(input[2].split(" -> ")[1]);
    obj.age = age;
    let grade = Number(input[3].split(" -> ")[1]);
    obj.grade = grade;
    let date = input[4].split(" -> ")[1];
    obj.date = date;
    let town = input[5].split(" -> ")[1];
    obj.town = town;
    console.log(JSON.stringify(obj));
}

solve([
    "name -> Angel",
    "surname -> Georgiev",
    "age -> 20",
    "grade -> 6.00",
    "date -> 23/05/1995",
    "town -> Sofia"
]);