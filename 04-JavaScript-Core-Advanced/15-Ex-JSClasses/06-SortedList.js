class sortedCollection{
    constructor(){
        this.collection = [];
        this.size = this.collection.length;
    }

    add(elem){
        this.collection.push(elem);
        this.size += 1;
        this.sort();
    }

    remove(index){
        if(index >= 0 && index < this.collection.length){
            this.collection.splice(index, 1);
            this.size -= 1;
        }else{
            throw new Error('Invalid index!');
        }
    }

    get(index){
        if(index >= 0 && index < this.collection.length){
            return this.collection[index];
        }else{
            throw new Error('Invalid index!');
        }
    }

    sort(){
        this.collection.sort((a, b) => {
            return a-b;
        });
        //console.log(this.collection)
    }
}

let sc = new sortedCollection();
sc.add(5);
sc.add(3);
sc.remove(0);