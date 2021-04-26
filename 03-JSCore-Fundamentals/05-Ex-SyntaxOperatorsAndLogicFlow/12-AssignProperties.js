function solve([prop1, p1, prop2, p2, prop3, p3]) {
    let obj = {};
    obj[prop1] = p1;
    obj[prop2] = p2;
    obj[prop3] = p3;
    console.log(obj.valueOf());
}

solve(['name', 'Pesho', 'age', '23', 'gender', 'male']);
solve(['ssid', '90127461', 'status', 'admin', 'expires', '600']);