function solve(){
    let results = {};

    let arg = arguments;
    for (let argKey in arg) {
        let type = typeof arg[argKey];
        if (!Object.keys(results).includes(type)){
            results[type] = 0;
        }
        results[type] += 1;
        console.log(`${type}: ${arg[argKey]}`);
        //return `${type}: ${arg[argKey]}`;
    }

    let sortedKeys = Object.keys(results).sort((a, b) => {
        return results[b] - results[a];
    });

    sortedKeys.forEach((x) => {
        console.log(`${x} = ${results[x]}`);
        // return `${x} = ${results[x]}`;
    });
}

console.log(solve('cat', 42, function () { console.log('Hello world!'); }, 2));