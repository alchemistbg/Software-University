function solve(num1, num2, oper) {
    if (oper === '+') {
        sum(num1, num2);
    }else if (oper === '-') {
        subtraction(num1, num2);
    }else if (oper === '*') {
        multiply(num1, num2);
    }else if (oper === '/') {
        division(num1, num2);
    }

    function sum(n1, n2) {
        console.log(n1 + n2);
    }
    
    function subtraction(n1, n2) {
        console.log(n1 - n2);
    }
    
    function multiply(n1, n2) {
        console.log(n1 * n2);
    }

    function division(n1, n2) {
        console.log(n1 / n2);
    }
}

solve(2, 4, '+');
solve(3, 3, '/');
solve(18, -1, '*');