(function solve(){
    Array.prototype.last = function(){
        return this[this.length - 1];
    }

    Array.prototype.skip = function(n){
        return this.slice(n);
    }

    Array.prototype.take = function(n){
        return this.slice(0, n);
    }

    Array.prototype.sum = function(){
        return this.reduce((acc, curr) => {
            return acc +=curr;
        }, 0);
    }

    Array.prototype.average = function(){
        let sum = this.sum();
        return sum / this.length;
    }
}());

let arr = [1, 2, 340];
console.log(arr.last());
console.log(arr.skip(1));
console.log(arr.take(2));
console.log(arr.sum());
console.log(arr.average());