function solve([s1, s2, time]) {
    let dist1 = s1*time/3600*1000;
    let dist2 = s2*time/3600*1000;

    console.log(Math.abs(dist1-dist2));
}

solve([0, 60, 3600]);
solve([11, 10, 120]);
solve([5, -5, 40]);
