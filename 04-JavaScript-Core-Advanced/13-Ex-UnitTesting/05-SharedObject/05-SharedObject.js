let assert = require('chai').assert;
let jsdom = require('jsdom-global')();
let $ = require('jquery');

document.body.innerHTML = `
    <div id="wrapper">
        <input type="text" id="name">
        <input type="text" id="income">
    </div>
`;

sharedObject = {
    bookName: null,
    income: null,
    changeName: function (name) {
        if (name.length === 0) {
            return;
        }
        this.name = name;
        let newName = $('#bookName');
        newName.val(this.bookName);
    },
    changeIncome: function (income) {
        if (!Number.isInteger(income) || income <= 0) {
            return;
        }
        this.income = income;
        let newIncome = $('#income');
        newIncome.val(this.income);
    },
    updateName: function () {
        let newName = $('#bookName').val();
        if (newName.length === 0) {
            return;
        }
        this.name = newName;
    },
    updateIncome: function () {
        let newIncome = $('#income').val();
        if (isNaN(newIncome) || !Number.isInteger(Number(newIncome)) || Number(newIncome) <= 0) {
            return;
        }
        this.income = Number(newIncome);
    }
};


describe('Testing sharedObject object', function () {
    describe('Testing sharedObject initial condition', function(){
        it('should ', function () {
            let result = sharedObject.bookName;
            let expected = null;
            assert.equal(result, expected, "");
        });
        it('should ', function () {
            let result = sharedObject.income;
            let expected = null;
            assert.equal(result, expected, "");
        });
    });

    describe('Testing changeName function', function () {
        it('', function () {
            let input = '';
            let result = sharedObject.changeName(input);
            let expected = null;
            assert.equal(result, expected, "");
        });
        it('', function () {
            sharedObject.name = 'Kiro';
            sharedObject.changeName('');
            let result = sharedObject.bookName;
            let expected = 'Kiro';
            assert.equal(result, expected, "");
        });
        it('', function () {
            sharedObject.changeName('Pencho');
            let resultProp = sharedObject.bookName;
            let expectedProp = 'Pencho';
            let resultBox = $('#bookName').val();
            let expectedBox = 'Pencho';
            assert.equal(resultProp, expectedProp, "");
            assert.equal(resultBox, expectedBox, "");
        });
    });

    describe('Testing changeIncome function', function () {
        it('', function () {
            let input = 'abc';
            let result = sharedObject.changeIncome(input);
            let expected = null;
            assert.equal(result, expected, "");
        });
        it('', function () {
            let input = -2;
            let result = sharedObject.changeIncome(input);
            let expected = null;
            assert.equal(result, expected, "");
        });
        it('', function () {
            sharedObject.income = 20;
            sharedObject.changeIncome(-20);
            let result = sharedObject.income;
            let expected = 20;
            assert.equal(result, expected, "");
        });
        it('', function () {
            sharedObject.changeIncome(40);
            let resultProp = sharedObject.income;
            let expectedProp = 40;
            let resultBox = $('#income').val();
            let expectedBox = 40;
            assert.equal(resultProp, expectedProp, "");
            assert.equal(resultBox, expectedBox, "");
        });
        it('', function () {
            sharedObject.income = 50;
            $('#income').val(50);
            console.log(sharedObject.income)
            sharedObject.changeIncome(0);
            let resultProp = sharedObject.income;
            let expectedProp = 50;
            let resultBox = +$('#income').val();
            let expectedBox = 50;
            assert.equal(resultProp, expectedProp, "");
            assert.equal(resultBox, expectedBox, "");
        });
    });

    describe('Testing updateName function', function () {
        it('', function () {
            let input = '';
            let result = sharedObject.updateName(input);
            let expected = null;
            assert.equal(result, expected, "");
        });
        it('', function () {
            sharedObject.name = 'Stefka';
            $('#bookName').val('');
            sharedObject.updateName();
            let result = sharedObject.bookName;
            let expected = 'Stefka';
            assert.equal(result, expected, "");
        });
        it('', function () {
            $('#bookName').val('Penka');
            sharedObject.updateName();
            let result = sharedObject.bookName;
            let expected = 'Penka';
            assert.equal(result, expected, "");
        });
    });

    describe('Testing updateIncome function', function () {
        it('', function () {
            let input = 'dfg';
            let result = sharedObject.updateIncome(input);
            let expected = null;
            assert.equal(result, expected, "");
        });
        it('', function () {
            sharedObject.income = 50;
            $('#income').val('abc');
            sharedObject.updateIncome();
            let result = sharedObject.income;
            let expected = 50;
            assert.equal(result, expected, "");
        });
        it('', function () {
            sharedObject.income = 50;
            $('#income').val(-10);
            sharedObject.updateIncome();
            let result = sharedObject.income;
            let expected = 50;
            assert.equal(result, expected, "");
        });
        it('', function () {
            sharedObject.income = 50;
            $('#income').val(1.55);
            sharedObject.updateIncome();
            let result = sharedObject.income;
            let expected = 50;
            assert.equal(result, expected, "");
        });
        it('', function () {
            sharedObject.income = 50;
            $('#income').val(150);
            sharedObject.updateIncome();
            let result = sharedObject.income;
            let expected = 150;
            assert.equal(result, expected, "");
        });
        it('', function () {
            sharedObject.income = 50;
            $('#income').val(0);
            sharedObject.updateIncome();
            let result = sharedObject.income;
            let expected = 50;
            assert.equal(result, expected, "");
        });
    });
});