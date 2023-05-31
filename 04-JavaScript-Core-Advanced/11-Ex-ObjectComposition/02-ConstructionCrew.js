function modifier(worker) {
    if (worker.handsShaking){
        worker.bloodAlcoholLevel += worker.weight * worker.experience * 0.1;
        worker.handsShaking = false;
    }
    return worker;
}

let worker = { weight: 95,
    experience: 3,
    bloodAlcoholLevel: 0,
    handsShaking: false }
;
console.log(modifier(worker));