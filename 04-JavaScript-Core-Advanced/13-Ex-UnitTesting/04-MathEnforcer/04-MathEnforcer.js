let assert = require('chai').assert;

let mathEnforcer = {
    addFive: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num + 5;
    },
    subtractTen: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num - 10;
    },
    sum: function (num1, num2) {
        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        }
        return num1 + num2;
    }
};

describe("Testing mathEnforcer", function () {
    //Test input
    it('Test addFive: should return undefined if input isn\'t number', function () {
        let input = '';
        let result = mathEnforcer.addFive(input);
        let expected = undefined;
        assert.equal(result, expected);
    });
    it('Test subtractTen: should return undefined if input isn\'t number', function () {
        let input = '';
        let result = mathEnforcer.subtractTen(input);
        let expected = undefined;
        assert.equal(result, expected);
    });
    it('Test sum: should return undefined if 1st input isn\'t number', function () {
        let input1 = '';
        let input2 = 2;
        let result = mathEnforcer.sum(input1, input2);
        let expected = undefined;
        assert.equal(result, expected);
    });
    it('Test sum: should return undefined if 2nd input isn\'t number', function () {
        let input1 = 2;
        let input2 = '';
        let result = mathEnforcer.sum(input1, input2);
        let expected = undefined;
        assert.equal(result, expected);
    });
    it('Test sum: should return undefined if both input isn\'t number', function () {
        let input1 = '';
        let input2 = '';
        let result = mathEnforcer.sum(input1, input2);
        let expected = undefined;
        assert.equal(result, expected);
    });
    //Test basic functionality
    it('should ', function () {
        let input = 5;
        let result = mathEnforcer.addFive(input);
        let expected = 10;
        assert.equal(result, expected)
    });
    it('should ', function () {
        let input = -5;
        let result = mathEnforcer.addFive(input);
        let expected = 0;
        assert.equal(result, expected)
    });
    it('should ', function () {
        let input = 1.2;
        let result = mathEnforcer.addFive(input);
        console.log(result);
        let expected = 6.2;
        assert.closeTo(result, expected, 0.01);
    });
    it('should ', function () {
        let input = 5;
        let result = mathEnforcer.subtractTen(input);
        let expected = -5;
        assert.equal(result, expected)
    });
    it('should ', function () {
        let input = -5;
        let result = mathEnforcer.subtractTen(input);
        let expected = -15;
        assert.equal(result, expected)
    });
    it('should ', function () {
        let input = 25.25;
        let result = mathEnforcer.subtractTen(input);
        let expected = 15.25;
        assert.closeTo(result, expected, 0.01);
    });
    it('should ', function () {
        let input1 = 5;
        let input2 = 25;
        let result = mathEnforcer.sum(input1, input2);
        let expected = 30;
        assert.equal(result, expected)
    });
    it('should ', function () {
        let input1 = -5;
        let input2 = 25;
        let result = mathEnforcer.sum(input1, input2);
        let expected = 20;
        assert.equal(result, expected)
    });

    it('should ', function () {
        let input1 = 2.25;
        let input2 = 2.5;
        let result = mathEnforcer.sum(input1, input2);
        let expected = 4.75;
        assert.closeTo(result, expected, 0.01);
    });
});