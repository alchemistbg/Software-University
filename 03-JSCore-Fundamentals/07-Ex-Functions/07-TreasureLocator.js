function solve(input) {
    let cook = {x1:4, x2:9, y1:7, y2:8}
    let samoa = {x1:5, x2:7, y1:3, y2:6}
    let tokelau = {x1:8, x2:9, y1:0, y2:1}
    let tonga = {x1:0, x2:2, y1:6, y2:8}
    let tuvalu = {x1:1, x2:3, y1:1, y2:3}

    for (let i = 0; i < input.length; i+=2) {
        // console.log(input[i] + ":" + input[i+1]);
        if (isInCook(input[i], input[i+1])) {
            console.log('Cook');
        }else if (isInSamoa(input[i], input[i+1])) {
            console.log('Samoa');
        }else if (isInTokelau(input[i], input[i+1])) {
            console.log('Tokelau');
        }else if (isInTonga(input[i], input[i+1])) {
            console.log('Tonga');
        }else if (isInTuvalu(input[i], input[i+1])) {
            console.log('Tuvalu');
        }else{
            console.log('On the bottom of the ocean');
        }
    }

    function isInCook(x, y) {
        if (cook.x1 <= x && x <= cook.x2 && cook.y1 <= y  && y <= cook.y2) {
            return true;
        }
    }
    function isInSamoa(x, y) {
        if (samoa.x1 <= x && x <= samoa.x2 && samoa.y1 <= y  && y <= samoa.y2) {
            return true;
        }
    }
    function isInTokelau(x, y) {
        if (tokelau.x1 <= x && x <= tokelau.x2 && tokelau.y1 <= y  && y <= tokelau.y2) {
            return true;
        }
    }
    function isInTonga(x, y) {
        if (tonga.x1 <= x && x <= tonga.x2 && tonga.y1 <= y  && y <= tonga.y2) {
            return true;
        }
    }
    function isInTuvalu(x, y) {
        if (tuvalu.x1 <= x && x <= tuvalu.x2 && tuvalu.y1 <= y  && y <= tuvalu.y2) {
            return true;
        }
    }
}

solve([4, 2, 1.5, 6.5, 1, 3]);
solve([6, 4]);