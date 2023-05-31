let assert = require('chai').assert;

class SubscriptionCard {
    constructor(firstName, lastName, SSN) {
        this._firstName = firstName;
        this._lastName = lastName;
        this._SSN = SSN;
        this._subscriptions = [];
        this._blocked = false;
    }

    get firstName() {
        return this._firstName;
    }

    get lastName() {
        return this._lastName;
    }

    get SSN() {
        return this._SSN;
    }

    get isBlocked() {
        return this._blocked;
    }

    addSubscription(line, startDate, endDate) {
        this._subscriptions.push({
            line,
            startDate,
            endDate
        });
    }

    isValid(line, date) {
        if (this.isBlocked) {
            return false
        }

        return this._subscriptions.filter(s => s.line === line || s.line === '*')
            .filter(s => {
                return s.startDate <= date &&
                    s.endDate >= date;
            }).length > 0;
    }

    block() {
        this._blocked = true;
    }

    unblock() {
        this._blocked = false;
    }
}

module.exports = SubscriptionCard;

describe('Check SubscriptionCard class', function () {
    let card;
    beforeEach(function () {
        card = new SubscriptionCard('Pesho', 'Petrov', '2222card');
    });
    it('Check object creation', function () {
        assert.instanceOf(card, SubscriptionCard);
        assert.exists(card.firstName);
        assert.exists(card.lastName);
        assert.exists(card.SSN);
        assert.exists(card.isBlocked);
        assert.exists(card._subscriptions);
        // assert.exists(card._blocked);
        assert.property(card, 'addSubscription');
        assert.property(card, 'isValid');
        assert.property(card, 'block');
        assert.property(card, 'unblock');
    });
    it('Check some functionality - firstName', function () {
        assert.equal(card.firstName, 'Pesho');
        assert.typeOf(card.firstName, 'string');
        card.firstName = 'Gosho';
        assert.equal(card.firstName, 'Pesho');
    });
    it('Check some functionality - lastName', function () {
        assert.equal(card.lastName, 'Petrov');
        assert.typeOf(card.lastName, 'string');
        card.lastName = 'Peshov';
        assert.equal(card.lastName, 'Petrov');
    });
    it('Check some functionality - SSN', function () {
        assert.equal(card.SSN, '2222card');
        assert.typeOf(card.SSN, 'string');
        card.SSN = '4444card';
        assert.equal(card.SSN, '2222card');
    });
    it('Check some functionality - isValid, block, unblock', function () {
        let result = card._blocked;
        assert.equal(result, false);
        assert.equal(card.isBlocked, false);
        assert.typeOf(result, 'boolean');
        result._blocked = true;
        assert.equal(result, false);
        card.block();
        assert.equal(card.isBlocked, true);
        assert.equal(card._blocked, true);
        card.unblock();
        assert.equal(card.isBlocked, false);
        assert.equal(card._blocked, false);
    });
    it('Check some functionality - _subscriptions', function () {
        let result = card._subscriptions;
        assert.isArray(result);
        assert.equal(result.length, 0);
    });
    it('Check some functionality - addSubscription', function () {
        assert.equal(card._subscriptions.length, 0);
        card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
        assert.equal(card._subscriptions.length, 1);
        assert.typeOf(card._subscriptions[0].line, 'string');
        assert.typeOf(card._subscriptions[0].startDate, 'date');
        assert.typeOf(card._subscriptions[0].endDate, 'date');
        assert.equal(card.isValid('120', new Date('2018-04-30')), true);
        assert.equal(card.isValid('120', new Date('2018-04-21')), false);
        assert.equal(card.isValid('120', new Date('2018-05-22')), false);
        card.block();
        assert.equal(card.isValid('120', new Date('2018-04-30')), false);
        card.unblock();
        assert.equal(card.isValid('120', new Date('2018-04-30')), true);
        assert.equal(card.isValid('125', new Date('2018-04-30')), false);
        card.addSubscription('*', new Date('2018-05-25'), new Date('2018-06-24'));
        assert.equal(card._subscriptions.length, 2);
        assert.equal(card.isValid('*', new Date('2018-05-25')), true);
        assert.equal(card.isValid('*', new Date('2018-06-24')), true);
        assert.equal(card.isValid('*', new Date('2018-05-24')), false);
        assert.equal(card.isValid('*', new Date('2018-06-25')), false);
        card.block();
        assert.equal(card.isValid('*', new Date('2018-05-25')), false);
        assert.equal(card.isValid('*', new Date('2018-06-24')), false);
        card.unblock();
        assert.equal(card.isValid('*', new Date('2018-05-25')), true);
        assert.equal(card.isValid('*', new Date('2018-06-24')), true);
    });
});


// describe('Check SubscriptionCard properties and functions', function () {
//     it('should be instance of SubscriptionCard', function () {
//         let testClass = new SubscriptionCard('Pesho', 'Goshov', '123456');
//         assert.instanceOf(testClass, SubscriptionCard);
//     });
//     it('should have firstName property', function () {
//         let testClass = new SubscriptionCard('Pesho', 'Goshov', '123456');
//         assert.typeOf(testClass.firstName, 'string');
//     });
//     it('should have lastName property', function () {
//         let testClass = new SubscriptionCard('Pesho', 'Goshov', '123456');
//         assert.typeOf(testClass.lastName, 'string');
//     });
//     it('should have subscriptions property', function () {
//         let testClass = new SubscriptionCard('Pesho', 'Goshov', '123456');
//         let result = testClass._subscriptions.length;
//         assert.equal(result, 0);
//         //console.log(testClass._subscriptions)
//         //assert.typeOf(testClass._subscriptions, 'object');
//     });
//     it('should have SSN property', function () {
//         let testClass = new SubscriptionCard('Pesho', 'Goshov', '123456');
//         assert.typeOf(testClass.SSN, 'string');
//     });
//     it('should have isBlocked property', function () {
//         let testClass = new SubscriptionCard();
//         assert.typeOf(testClass.isBlocked, 'boolean');
//         assert.equal(testClass.isBlocked, false);
//     });
//     it('should have addSubscription() function', function () {
//         let testClass = new SubscriptionCard();
//         assert.typeOf(testClass.addSubscription, 'function');
//     });
//     it('should have isValid() function', function () {
//         let testClass = new SubscriptionCard();
//         assert.typeOf(testClass.isValid, 'function');
//     });
//     it('should have block() function', function () {
//         let testClass = new SubscriptionCard();
//         assert.typeOf(testClass.block, 'function');
//     });
//     it('should have unblock() function', function () {
//         let testClass = new SubscriptionCard();
//         assert.typeOf(testClass.unblock, 'function');
//     });
// });
//
// describe('Check SubscriptionCard functionality', function () {
//     it('should ', function () {
//         let testClass = new SubscriptionCard('Pesho', 'Petrov', '00000000');
//         let fNameResult = testClass.firstName;
//         assert.equal(fNameResult, 'Pesho');
//         let lNameResult = testClass.lastName;
//         assert.equal(lNameResult, 'Petrov');
//         let ssnResult = testClass.SSN;
//         assert.equal(ssnResult, '00000000');
//         assert.equal(testClass._subscriptions.length, 0);
//         assert.equal(testClass.isBlocked, false)
//         // testClass.block();
//         // assert.equal(testClass.isBlocked, true);
//         // assert.equal(testClass.isValid(), false);
//         // testClass.unblock();
//         // assert.equal(testClass.isBlocked, false);
//         // testClass.firstName = 'Gosho';
//         // assert.equal(fNameResult, 'Pesho');
//     });
//     it('should ', function () {
//         let testClass = new SubscriptionCard(123, 'Petrov', '00000000');
//         assert.equal(testClass.firstName, 123);
//     });
//     // it('should ', function () {
//     //     let testClass = new SubscriptionCard('Pesho', 'Petrov', '00000000');
//     //     testClass.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
//     //     assert.equal(testClass._subscriptions.length, 1);
//     //     testClass.addSubscription('*', new Date('2018-05-25'), new Date('2018-06-24'));
//     //     assert.equal(testClass._subscriptions.length, 2);
//     //     assert.equal(testClass._subscriptions[0].line, '120');
//     //     let isValidResult1 = testClass.isValid('120', new Date('2018-04-22'));
//     //     assert.equal(isValidResult1, true);
//     //     let isValidResult2 = testClass.isValid('*', new Date('2018-05-28'));
//     //     assert.equal(isValidResult2, true);
//     //     let isValidResult3 = testClass.isValid('45', new Date('2018-09-28'));
//     //     assert.equal(isValidResult3, false);
//     // });
// });