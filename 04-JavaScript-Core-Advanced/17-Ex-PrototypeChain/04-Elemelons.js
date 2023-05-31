function solve() {
    class Melon {
        constructor(weight, melonSort) {
            if (new.target === Melon) {
                throw new TypeError("Abstract class cannot be instantiated directly");
            }
            this.weight = weight;
            this.melonSort = melonSort;
        }
    }

    class Watermelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Water';
            this._elementIndex = weight * melonSort.length;
        }

        get elementIndex() {
            return this._elementIndex;
        }

        toString() {
            let output = `Element: ${this.element}\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`;
            return output;
        }
    }

    class Firemelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Fire';
            this._elementIndex = weight * melonSort.length;
        }

        get elementIndex() {
            return this._elementIndex;
        }

        toString() {
            let output = `Element: ${this.element}\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`;
            return output;
        }
    }

    class Earthmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Earth';
            this._elementIndex = weight * melonSort.length;
        }

        get elementIndex() {
            return this._elementIndex;
        }

        toString() {
            let output = `Element: ${this.element}\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`;
            return output;
        }
    }

    class Airmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Air';
            this._elementIndex = weight * melonSort.length;
        }

        get elementIndex() {
            return this._elementIndex;
        }

        toString() {
            let output = `Element: ${this.element}\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`;
            return output;
        }
    }

    class Melolemonmelon extends Watermelon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.morphs = 0;
        }

        morph() {
            let melons = ['Water', 'Fire', 'Earth', 'Air'];
            this.morphs++;
            this.element = melons[this.morphs % 4];
        }
    }

    return {
        Melon,
        Watermelon,
        Firemelon,
        Earthmelon,
        Airmelon,
        Melolemonmelon
    }
}

let classes = solve();

let melon1 = new classes.Melolemonmelon(150, "Melo");
// console.log(melon1.toString());
melon1.morph();
// console.log(melon1.morphs)
// console.log(melon1.toString());
melon1.morph();
// console.log(melon1.morphs)
console.log(melon1.toString());
// melon1.morph();
// console.log(melon1.morphs)
// console.log(melon1.toString());
