let assert = require('chai').assert;

class Calculator {
    constructor() {
        this.expenses = [];
    }

    add(data) {
        this.expenses.push(data);
    }

    divideNums() {
        let divide;
        for (let i = 0; i < this.expenses.length; i++) {
            if (typeof (this.expenses[i]) === 'number') {
                if (i === 0 || divide===undefined) {
                    divide = this.expenses[i];
                } else {
                    if (this.expenses[i] === 0) {
                        return 'Cannot divide by zero';
                    }
                    divide /= this.expenses[i];
                }
            }
        }
        if (divide !== undefined) {
            this.expenses = [divide];
            return divide;
        } else {
            throw new Error('There are no numbers in the array!')
        }
    }

    toString() {
        if (this.expenses.length > 0)
            return this.expenses.join(" -> ");
        else return 'empty array';
    }

    orderBy() {
        if (this.expenses.length > 0) {
            let isNumber = true;
            for (let data of this.expenses) {
                if (typeof data !== 'number')
                    isNumber = false;
            }
            if (isNumber) {
                return this.expenses.sort((a, b) => a - b).join(', ');
            }
            else {
                return this.expenses.sort().join(', ');
            }
        }
        else return 'empty';
    }
}

describe('', function () {
    describe('Check if class have desired properties and functions', function () {
        it('should be instance of Calculator class', function () {
            let testClass = new Calculator();
                assert.instanceOf(testClass, Calculator);
        });

        it('should be initialize with array expenses', function () {
            let testClass = new Calculator();
            assert.equal(typeof testClass.expenses, 'object');
        });

        it('should be initialize with empty expenses array', function () {
            let testClass = new Calculator();
            let result = testClass.expenses.length;
            assert.equal(result, 0);
        });

        it('should have add function', function () {
            let testClass = new Calculator();
            assert.typeOf(testClass.add, 'function');
        });

        it('should have divide function', function () {
            let testClass = new Calculator();
            assert.typeOf(testClass.divideNums, 'function');
        });

        it('should have toString function', function () {
            let testClass = new Calculator();
            assert.typeOf(testClass.toString, 'function');
        });

        it('should have orderBy function', function () {
            let testClass = new Calculator();
            assert.typeOf(testClass.orderBy, 'function');
        });
    });

    describe('Check class functionality', function () {
        describe('Check add() functionality', function () {
            it ('should add 10, "Pesho" and "5" to expenses array', function () {
                let testClass = new Calculator();
                let result = testClass.expenses;
                result.push(10);
                result.push('Pesho');
                result.push('5');
                assert.equal(result[0], 10);
                assert.equal(result[1], 'Pesho');
                assert.equal(result[2], '5');
            });
        });

        describe('Check toString() functionality', function () {
            it('should return empty array', function () {
                let testClass = new Calculator();
                let result = testClass.toString();
                assert.equal(result, 'empty array');
            });
            it('should ', function () {
                let testClass = new Calculator();
                testClass.add(10);
                testClass.add('Pesho');
                testClass.add('5');
                assert.equal(testClass.toString(), '10 -> Pesho -> 5');
            });
        });

        describe('Check orderBy() functionality', function () {
            it('should return empty', function () {
                let testClass = new Calculator();
                let result = testClass.orderBy();
                assert.equal(result, 'empty');
            });
            it('should return 10, 5, Pesho if input is 10, Pesho, 5', function () {
                let testClass = new Calculator();
                testClass.add(10);
                testClass.add('Pesho');
                testClass.add('5');
                assert.equal(testClass.orderBy(), '10, 5, Pesho');
            });
        });

        describe('Check divide() functionality', function f() {
            it('should throw an error if input is Pesho, Gosho', function () {
                let testClass = new Calculator();
                testClass.add('Pesho');
                testClass.add('Gosho');
                assert.throw(function () {
                    testClass.divideNums();
                }, 'There are no numbers in the array!')
            });
            it('should return "Cannot divide by zero" if input is 5 and 0', function () {
                let testClass = new Calculator();
                testClass.add(5);
                testClass.add(0);
                assert.equal(testClass.divideNums(), 'Cannot divide by zero');
            });
            it('should return 5 if input is 20 and 4', function () {
                let testClass = new Calculator();
                testClass.add(20);
                testClass.add(4);
                assert.equal(testClass.divideNums(), 5);
            });
        });
    });
});