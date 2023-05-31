let calcE = function calcE(M, e) {
    let E0 = Math.max(M, e);

    let func = function f(E){
        let iE = +E.toFixed(9);
        let numerator = (iE - (e * Math.sin(iE)) - M);
        let divisor = (1 - (e * Math.cos(iE)));
        let result = iE - (numerator / divisor);
        if (+result.toFixed(9) !== iE){
            return func(result);
        }else {
            let numPart = Math.trunc(result);
            let decPart = +(result - numPart).toFixed(9);
            return numPart + decPart;
        }
    }

    return func(E0);
};

console.log(calcE(0.25, 0.99))