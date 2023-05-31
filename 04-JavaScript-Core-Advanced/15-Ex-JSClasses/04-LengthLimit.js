class Stringer{
    constructor(str, len) {
        this.innerString = str;
        this.innerLength = len;
    }

    increase(newLen){
        this.innerLength += newLen;
    }
    
    decrease(newLen){
        if (this.innerLength - newLen < 0){
            return this.innerLength = 0;
        }
        return this.innerLength -= newLen;
    }
    toString(){
        console.log(this.innerLength)
        if (this.innerString.length > this.innerLength){
            return this.innerString.substring(0, this.innerLength) + '...';
        }
        if (this.innerLength === 0){
            return '...';
        }
        return this.innerString;
    }
}

let test = new Stringer("Test", 5);
console.log(test.toString()); //Test

test.decrease(3);
console.log(test.toString()); //Te...

test.decrease(5);
console.log(test.toString()); //...

test.increase(4);
console.log(test.toString()); //Test
