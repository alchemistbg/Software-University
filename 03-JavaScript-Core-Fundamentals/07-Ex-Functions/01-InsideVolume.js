function solve(arr) {

    for (let i = 0; i < arr.length; i+=3) {
        let x = arr[i];
        let y = arr[i+1];
        let z = arr[i+2];

        if (isInVolume(x, y, z)) {
            console.log("inside");
        }else{
            console.log("outside");
        }
    }

    function isInVolume(x, y, z){
        let x1 = 10, x2 = 50;
        let y1 = 20, y2 = 80;
        let z1 = 15, z2 = 50;

        if (x >= x1 && x <= x2 && y >= y1 && y <= y2 && z >= z1 && z <= z2) {
            return true;
        }
        return false;
    }
}

solve([8, 20, 22]);
solve([13.1, 50, 31.5, 50, 80, 50, -5, 18, 43]);

