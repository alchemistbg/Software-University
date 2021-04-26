function solve(n) {
    let dashNumber = n - 2;
    if (n % 2 == 0) {
        for (let i = 1; i <= n-1; i++) {
            //console.log(n/2);
            if (i === 1 || i === n/2 || i === n-1) {
                console.log(`+${"-".repeat(dashNumber)}+${"-".repeat(dashNumber)}+`);
            }else{
                console.log(`|${" ".repeat(dashNumber)}|${" ".repeat(dashNumber)}|`);
            }
        }
    }else{
        for (let i = 1; i <= n; i++) {
            if (i === 1 || i === (n+1)/2 || i === n) {
                console.log(`+${"-".repeat(dashNumber)}+${"-".repeat(dashNumber)}+`);
            }else{
                console.log(`|${" ".repeat(dashNumber)}|${" ".repeat(dashNumber)}|`);
            }
        }
    }
}

//solve(2)
//solve(3)
//solve(4)
//solve(5)
solve(6)
//solve(7)