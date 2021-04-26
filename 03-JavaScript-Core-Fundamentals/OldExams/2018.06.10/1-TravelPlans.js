function solve(input) {
    let totalIncome = 0;

    let specialized = ['Programming', 'Hardware maintenance', 'Cooking', 'Translating', 'Designing'];
    let average = ['Driving', 'Managing', 'Fishing', 'Gardening'];
    let clumsy = ['Singing', 'Accounting', 'Teaching', 'Exam-Making', 'Acting', 'Writing', 'Lecturing', 'Modeling', 'Nursing'];

    let specCounter = 1;
    let clumCounter = 1;
    for (let iLine of input) {
        let task = iLine.split(' : ')[0];
        let gold = +iLine.split(' : ')[1];

        if (specialized.includes(task) && gold >= 200) {
            gold *= 0.8;
            if (specCounter % 2 === 0) {
                gold += 200;
            }
            specCounter++;

            totalIncome += gold;

        } else if (clumsy.includes(task)) {
            if (clumCounter % 2 === 0) {
                gold *= 0.95;
            }
            else if (clumCounter % 3 === 0) {
                gold *= 0.9;
            }
            // else if (clumCounter % 6 === 0) {
            //     gold *= 0.95;
            //     gold *= 0.9;
            // }
            clumCounter++;

            totalIncome += gold;

        } else if (average.includes(task)) {
            totalIncome += gold;
        }
    }

    let diff = totalIncome - 1000;
    console.log(`Final sum: ${totalIncome.toFixed(2)}`);
    if (diff >= 0) {
        console.log(`Mariyka earned ${diff.toFixed(2)} gold more.`)
    }else{
        diff *= -1.00;
        console.log(`Mariyka need to earn ${diff.toFixed(2)} gold more to continue in the next task.`)
    }
}

solve(["Programming : 500", "Driving : 243", "Singing : 100", "Cooking : 199"]);
console.log()
// solve(["Programming : 500", "Driving : 243.55", "Acting : 200", "Singing : 100", "Cooking : 199",
//     "Hardware maintenance : 800", "Gardening : 700", "Programming : 500"]);
solve(["Programming : 300", "Cooking : 75", "Hardware maintenance : 50"]);