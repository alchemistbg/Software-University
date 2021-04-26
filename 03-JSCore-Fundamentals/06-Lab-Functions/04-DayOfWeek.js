function solve(input) {
    let days = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];
    if (days.includes(input)) {
        console.log(days.indexOf(input)+1);
    }else {
        console.log('error');
    }
}

solve('Monday');
solve('Friday');
solve('Frabjoyousday');