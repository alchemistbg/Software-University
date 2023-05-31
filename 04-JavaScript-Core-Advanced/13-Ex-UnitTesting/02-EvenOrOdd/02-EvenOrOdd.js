let assert = require('chai').assert;

function isOddOrEven(string) {
    if (typeof(string) !== 'string') {
        return undefined;
    }
    if (string.length % 2 === 0) {
        return "even";
    }

    return "odd";
}

describe("Testing isOddOrEven", function () {
    it('Testing input: should return undefined if [] is passed in', function () {
        let input = [];
        let result = isOddOrEven(input);
        let expected = undefined;
        assert.equal(expected, result);
    });
    it('Testing odd input', function () {
        let input = 'Pesho';
        let result = isOddOrEven(input);
        let expected = 'odd';
        assert.equal(expected, result);
    });
    it('Testing even input', function () {
        let input = 'Kiro';
        let result = isOddOrEven(input);
        let expected = 'even';
        assert.equal(expected, result);
    });
});