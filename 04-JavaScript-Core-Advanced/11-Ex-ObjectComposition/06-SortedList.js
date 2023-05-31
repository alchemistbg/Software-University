function sortedCollection() {
    return {
        list: [],
        size: 0,
        add: function (elem) {
            this.list.push(elem);
            this.size += 1;
            this.sort();
        },
        remove: function (index) {
            if (index >= 0 && index < this.list.length) {
                this.list.splice(index, 1);
                this.size -= 1;
            }else{
                throw 'Some big error';
            }
        },
        get: function (index) {
            if (index >= 0 && index < this.list.length) {
                return this.list[index];
            }else{
                throw 'Some big error';
            }
        },
        sort: function () {
            this.list.sort((a, b) =>{
                return a-b;
            });
        }
    }
}

let sc = sortedCollection();
sc.add(5);