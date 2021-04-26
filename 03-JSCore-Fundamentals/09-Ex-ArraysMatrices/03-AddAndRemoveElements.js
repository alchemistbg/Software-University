function solve(commands) {
    let arr = [];
    for (let i = 0; i < commands.length; i++) {
        if (commands[i] === 'add') {
            arr.push(i+1);
        }
        else {
            arr.pop();
        }
    }
    if (arr.length === 0) {
        console.log('Empty');
    }else{
        console.log(arr.join('\n'));
    }
}

solve([
    'add',
    'add',
    'add',
    'add'
]);
console.log();
solve([
    'add',
    'add',
    'remove',
    'add',
    'add',

]);
console.log();
solve([
    'remove',
    'remove',
    'remove'
]);