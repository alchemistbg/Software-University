class CheckingAccount {
    constructor(clientID, eMail, fName, lName) {
        if (this.validateID(+clientID)) {
            this.clientID = +clientID;
        } else {
            throw TypeError('Client ID must be a 6-digit number');
        }

        if (this.validateEmail(eMail)){
            this.eMail = eMail;
        } else {
            throw TypeError('Invalid e-mail');
        }

        if (this.validateNameLength(fName) && this.validateNameSymbols(fName)) {
            this.firstName = fName;
        } else {
            if (!this.validateNameLength(fName)) {
                throw TypeError('First bookName must be between 3 and 20 characters long');
            }
            if (!this.validateNameSymbols(fName)) {
                throw TypeError('First bookName must contain only Latin characters');
            }
        }

        if (this.validateNameLength(lName) && this.validateNameSymbols(lName)) {
            this.lastName = lName;
        } else {
            if (!this.validateNameLength(lName)) {
                throw TypeError('Last bookName must be between 3 and 20 characters long');
            }
            if (!this.validateNameSymbols(lName)) {
                throw TypeError('Last bookName must contain only Latin characters');
            }
        }
        this.products = [];
    }

    validateID(id) {
        if (/^\d{6}$/.test(id)) {
            return true;
        }
        return false;
    }

    validateEmail(eMail) {
        if (/[A-Za-z\d]+?@[\.A-Za-z]+?/.test(eMail)) {
            return true
        }
        return false;
    }

    validateNameLength(name) {
        if (/^.{3,20}$/.test(name)) {
            return true;
        }else {
            return false;
        }

    }

    validateNameSymbols(name) {
        if (!/[^A-Za-z]/.test(name)) {
            return true;
        }
        return false;
    }
}

// let acc1 = new CheckingAccount('131415', 'ivan@some.com', 'Ivan', 'Petrov');
// let acc2 = new CheckingAccount('423415', 'petkan@another.co.uk', 'Petkan', 'Draganov');
let acc3 = new CheckingAccount('423414', 'petkan@another.co.uk', 'Petkzfdgd5', 'Draganov');