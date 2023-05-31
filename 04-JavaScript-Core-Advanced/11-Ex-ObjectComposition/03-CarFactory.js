function solve(order) {
    let engines = {
        small: {power: 90, volume: 1800},
        normal: {power: 120, volume: 2400},
        monster: {power: 200, volume: 3500}
    };

    let carriages = {
        hatchback: {type: 'hatchback', color: ''},
        coupe: {type: 'coupe', color: ''}
    };

    let car = {};
    car.model = order.model;

    if (order.power <= engines.small.power) {
        car.engine = engines.small;
    } else if (order.power > engines.small.power && order.power <= engines.normal.power) {
        car.engine = engines.normal;
    } else {
        car.engine = engines.monster;
    }

    if (order.carriage === 'hatchback') {
        car.carriage = carriages.hatchback;
        car.carriage.color = order.color;
    } else {
        car.carriage = carriages.coupe;
        car.carriage.color = order.color;
    }

    let orderWheels = order.wheelsize;
    if (orderWheels % 2 === 0){
        orderWheels -= 1;
    }
    car.wheels = [orderWheels, orderWheels, orderWheels, orderWheels];
    return car;
}

let clientOrder1 = {
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
};
console.log(solve(clientOrder1));

let clientOrder2 = {
    model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17
};
console.log(solve(clientOrder2));