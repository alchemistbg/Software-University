class Rat{
    constructor(name){
        this.name = name;
        this.unitedRats = [];
    }

    unite(rat){
        if(rat instanceof Rat){
        //if(Object.getPrototypeOf(this) === Object.getPrototypeOf(rat)){
            this.unitedRats.push(rat);
        }
    }

    getRats(){
        return this.unitedRats;
    }

    toString() {
        let output = this.bookName;
        this.unitedRats.forEach((rat) => {
            output += '\n##' + rat.bookName;
        });
        return output;
    };
}

let rat1 = new Rat("Pesho");
console.log(rat1.toString()); //Pesho
let rat2 = new Rat("Gosho");
console.log(rat2.toString()); //Gosho
let rat3 = new Rat("Kiro");
console.log(rat3.toString()); //Kiro
rat1.unite(rat2);
rat1.unite(rat3);
//console.log(rat1.getRats());
console.log(rat1.toString());;