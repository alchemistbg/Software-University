function solve(input){
    let finalThickness = input[0];

    let cut = x => x / 4;
    let lap = x => x * 0.8;
    let grind = x => x - 20;
    let etch = x => x - 2;
    let xray = x => x + 1;
    let tWash = x => Math.trunc(x);

    for (let i = 1; i < input.length; i++) {
        let currThickness = input[i];
        console.log(`Processing chunk ${currThickness} microns`);
        if (currThickness >= finalThickness * 4) {
            let counter = 0;
            while (currThickness / 4 >= finalThickness){
                counter++;
                currThickness = doSmth(currThickness, finalThickness, x => x/4)
            }
            console.log(`Cut x${counter}; ${currThickness}`);
        }
    }

    function doSmth(current, final, func) {
            current = func(current);
        return current;
    }


}

solve([1375, 50000]);
solve([1000, 4000]);
solve([1000, 8100]);
solve([1000, 4000, 8100]);
