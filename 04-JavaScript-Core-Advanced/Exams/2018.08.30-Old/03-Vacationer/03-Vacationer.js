class Vacationer{
    constructor(fullName, creditCard){
        // if (fullName.length !== 3){
        //     throw new Error('Name must include first bookName, middle bookName and last bookName');
        // }
        // let pattern = /^[A-Z][a-z]+$/g;
        // for (let i = 0; i < fullName.length; i++) {
        //     if (!fullName[i].match(pattern)) {
        //         throw new Error('Invalid full bookName');
        //     }
        // }
        //
        // this.fName = fullName[0];
        // this.mName = fullName[1];
        // this.lName = fullName[2];

        this.fullName = fullName;

        this.creditCard = {
            //Moje i da si v greshka
            cardNumber: 1111,
            expirationDate: "",
            securityNumber: 111
        };
        if (creditCard !== undefined) {
            //VNIMAVAI
            this.addCreditCardInfo(creditCard);
        }

        this.idNumber = this.generateIDNumber();

        // if (creditCard === undefined){
        //     this.cardNumber = 1111;
        //     this.expirationDate = '';
        //     this.securityNumber = 111;
        // } else {
        //     if (typeof creditCard[0] !== "number" || typeof creditCard[2] !== "number"){
        //         throw new Error('Invalid credit card details');
        //     }
        //     this.cardNumber = creditCard[0];
        //     this.expirationDate = creditCard[1];
        //     this.securityNumber = creditCard[2];
        // }

        this.wishList = [];
    }

    get fullName () {
        return this._fullName;
    };

    set fullName(input){
        if (input.length !== 3){
            throw new Error('Name must include first bookName, middle bookName and last bookName');
        }
        let pattern = /^[A-Z][a-z]+$/g;
        for (let i = 0; i < input.length; i++) {
            if (!input[i].match(pattern)) {
                throw new Error('Invalid full bookName');
            }
        }
        let fullName = {};
        fullName.fName = input[0];
        fullName.mName = input[1];
        fullName.lName = input[2];

        this._fullName = fullName;
    }


    // get creditCard(){
    //     return {
    //         cardNumber: this.cardNumber,
    //         expirationDate: this.expirationDate,
    //         securityNumber: this.securityNumber
    //     }
    // }

    addCreditCardInfo(input) {
        if (input.length !== 3) {
            throw new Error("Missing credit card information");
        }
        if (typeof input[0] !== "number" || typeof input[2] !== "number") {
            throw new Error("Invalid credit card details");
        }
        this.creditCard.cardNumber = input[0];
        this.creditCard.expirationDate = input[1];
        this.creditCard.securityNumber = input[2];
    }

    generateIDNumber() {
        let vowel = ['a', 'e', 'i', 'o', 'u'];
        //Formula
        let idNumber = (231 * this.fullName.fName.charCodeAt(0) + 139 *
            this.fullName.mName.length).toString();
        if (vowel.includes(this.fullName.lName.charAt(this.fullName.lName.length - 1))) {
            idNumber += 8;
        } else {
            idNumber += 7;
        }
        //MOJE I DA TRQBWA SETER
        return idNumber;
    }

    addDestinationToWishList(destination) {
        if (this.wishList.includes(destination)) {
            throw new Error("Destination already exists in wishlist");
        }
        this.wishList.push(destination);
        this.wishList.sort(function (a, b) {
            return a.length - b.length ;
        });
    }

    // getVacationerInfo(){
    //     let info = `Name: ${this.fullName.fName} ${this.fullName.mName} ${this.fullName.lName}\n`;
    //     info += `ID Number: ${this.idNumber}\n`;
    //     info += 'Wishlist:\n';
    //     if (this.wishList.length === 0){
    //         info += 'empty\n'
    //     }else{
    //         info += `${this.wishList.join(', ')}\n`;
    //     }
    //     info += 'Credit Card:\n';
    //     info += `Card Number: ${this.creditCard.cardNumber}\n`;
    //     info += `Expiration Date: ${this.creditCard.expirationDate}\n`;
    //     info += `Security Number: ${this.creditCard.securityNumber}`;
    //
    //     return info;
    // }

    getVacationerInfo(){
        //return `Name: ${this.fullName.firstName} ${this.fullName.middleName} ${this.fullName.lastName}
        //        ID Number: ${this.idNumber}
        //        Wishlist:
        //        ${(this.wishList.length === 0 ? "empty":this.wishList.join(', '))}
        //        Credit Card:
        //        Card Number: ${this.creditCard.cardNumber}
        //        Expiration Date: ${this.creditCard.expirationDate}
        //        Security Number: ${this.creditCard.securityNumber}`

        return "Name: " + this.fullName.fName + " " + this.fullName.mName + " " + this.fullName.lName + "\n" +
            "ID Number: " + this.idNumber + "\n" +
            "Wishlist:\n" + (this.wishList.length === 0 ? "empty" : this.wishList.join(", ")) + "\n" +
            "Credit Card:\n" +
            "Card Number: " + this.creditCard.cardNumber + "\n" +
            "Expiration Date: " + this.creditCard.expirationDate + "\n" +
            "Security Number: " + this.creditCard.securityNumber;
    }
}