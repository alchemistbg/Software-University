function solve(input) {
    let num = input[0];
    num = cookNumber(num);
    console.log(num)
    function cookNumber(n){
        for (let i = 1; i < input.length; i++) {
            switch (input[i]) {
                case 'bake':
                    n = doBake(n)//n = n * 3;
                    break;
                case 'chop':
                    n = doChop(n);//n = n / 2;
                    break;
                case 'dice':
                    n = doDice(n);//n = Math.sqrt(n);
                    break;
                case 'fillet':
                    n = doFillet(n);//n = n - n * 0.2;
                    break;
                case 'spice':
                    n = doSpice(n);//n = n + 1;
                    break;
            }
        }
        return n;
    }

    function doBake(n) {
        return n*3
    }
    function doChop(n) {
        return n / 2;
    }
    function doDice(n) {
        return Math.sqrt(n);
    }
    function doFillet(n) {
        return n - n * 0.2;
    }
    function doSpice(n) {
        return n+1;
    }
}

solve([32, 'chop', 'chop', 'chop', 'chop', 'chop'])
solve([9, 'dice', 'spice', 'chop', 'bake', 'fillet']);