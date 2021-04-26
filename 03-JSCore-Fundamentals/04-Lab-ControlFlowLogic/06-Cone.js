function solve(radius, height){
    let coneBaseArea = Math.PI*radius*radius;
    let coneArea = Math.PI*radius*radius + Math.PI*radius*Math.sqrt(radius**2 + height**2);
    let coneVolume = coneBaseArea * height / 3;
    console.log(`volume = ${coneVolume}`);
    console.log(`area = ${coneArea}`);
}

solve(
    3,
    5
);