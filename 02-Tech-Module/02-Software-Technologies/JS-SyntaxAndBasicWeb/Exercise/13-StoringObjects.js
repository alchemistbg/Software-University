function solve(input){
    let students = [];
    for (let i = 0; i < input.length; i++) {
        let tempArr = input[i].split(" -> ");
        let student = {
            name: tempArr[0],
            age: tempArr[1],
            grade: tempArr[2]
        };
        students.push(student);
    }

    for (let i = 0; i < students.length; i++) {
        console.log(`Name: ${students[i].name}`);
        console.log(`Age: ${students[i].age}`);
        console.log(`Grade: ${Number(students[i].grade).toFixed(10)}`);
    }
}

solve([
    "Pesho -> 13 -> 6.00",
    "Ivan -> 12 -> 5.57",
    "Toni -> 13 -> 4.90"
]);