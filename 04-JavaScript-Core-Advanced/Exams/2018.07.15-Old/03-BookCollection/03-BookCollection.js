class BookCollection {
    constructor(shelfGenre = '', room, shelfCapacity) {
        this.room = room;
        this.shelfGenre = shelfGenre;
        this.shelfCapacity = +shelfCapacity;
        this.shelf = [];
    }

    get room() {
        return this._room;
    }

    set room(val) {
        let allowedRooms = ["livingRoom", "bedRoom", "closet"];
        if (!allowedRooms.includes(val)) {
            throw new Error(`Cannot have book shelf in ${val}`);
        } else {
            this._room = val;
        }
    }

    get shelfCapacity() {
        return this._capacity;
    }

    set shelfCapacity(val) {
        this._capacity = val;
    }

    get shelfCondition() {
        return this.shelfCapacity - this.shelf.length;
    }

    addBook(bookName, bookAuthor, bookGenre = '') {
        let book = {
            bookName: bookName,
            bookAuthor: bookAuthor,
            bookGenre: bookGenre
        };

        if (this.shelfCapacity === this.shelf.length) {
            this.shelf.shift();
        }
        this.shelf.push(book);
        this.shelf.sort((a, b) => {
            return a.bookAuthor.localeCompare(b.bookAuthor);
        });
        return this;
    }

    throwAwayBook(name) {
        this.shelf = this.shelf.filter((book) => {
            return book.bookName !== name;
        });
        return this.shelf;
    }

    showBooks(genre) {
        let result = `Results for search "${genre}":\n`;
        let filtered = (this.shelf.filter((book) => {
            return book.bookGenre === genre;
        }));

        result += filtered.map(book => `\uD83D\uDCD6 ${book.bookAuthor} - "${book.bookName}"`).join('\n');
        return result;
    }

    toString() {
        let result = '';
        if (this.shelf.length < 1) {
            result = "It's an empty shelf";
        } else {
            result += `"${this.shelfGenre}" shelf in ${this.room} contains:\n`;
            result += this.shelf.map((book) => `\uD83D\uDCD6 "${book.bookName}" - ${book.bookAuthor}`).join('\n');
        }
        return result;
    }
}

// let livingRoom = new BookCollection("Programming", "livingRoom", 5)
//     .addBook("Introduction to Programming with C#", "Svetlin Nakov")
//     .addBook("Introduction to Programming with Java", "Svetlin Nakov")
//     .addBook("Programming for .NET Framework", "Svetlin Nakov");
// console.log(livingRoom.toString());


// let bc = new BookCollection("Programming", "closet");
// bc.addBook("It", "Stephen King", 'Horror');
// bc.addBook("Introduction to Programming with C#", "Azimov", 'abc');
// bc.addBook("Introduction to Programming with C#", "Dong", 'abc');
// bc.addBook("Introduction to Programming with C#", "Bong", 'abc');
// // console.log(bc.shelf);
// // console.log((bc.throwAwayBook('It')));
// console.log(bc.toString());
