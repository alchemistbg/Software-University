function solve(input) {
    console.log('<?xml version="1.0" encoding="UTF-8"?>\n<quiz>');

    for (let i = 0; i < input.length; i+=2) {
        printQ(input[i])
        printA(input[i+1]);
    }
    
    console.log('</quiz>');

    function printQ(q) {
        console.log(`  <question>\n${"    " + q}\n  </question>`);
    }

    function printA(a) {
        console.log(`  <answer>\n${"    " + a}\n  </answer>`);
    }
}

solve(["Who was the forty-second president of the U.S.A.?",
    "William Jefferson Clinton"]);
solve(["Dry ice is obj1 frozen form of which gas?",
    "Carbon Dioxide",
    "What is the brightest star in the night sky?",
    "Sirius"]
);