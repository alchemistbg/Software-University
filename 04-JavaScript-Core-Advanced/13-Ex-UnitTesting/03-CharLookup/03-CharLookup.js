let assert = require('chai').assert;

function lookupChar(string, index) {
    if (typeof(string) !== 'string' || !Number.isInteger(index)) {
        return undefined;
    }
    if (string.length <= index || index < 0) {
        return "Incorrect index";
    }

    return string.charAt(index);
}

describe("Testing lookupChar", function () {
    //Testing input validation
    it('Testing input: should return undefined if [] is passed in', function () {
        let input = {};
        let index = 3;
        let result = lookupChar(input, index);
        let expected = undefined;
        assert.equal(result, expected);
    });
    it('Testing input: should return undefined if float is passed in', function () {
        let input = 'asdf';
        let index = 3.5;
        let result = lookupChar(input, index);
        let expected = undefined;
        assert.equal(result, expected);
    });
    //Testing index value
    it('Testing input: should return "Incorrect index" if negative index is passed in', function () {
        let input = 'asdf';
        let index = -1;
        let result = lookupChar(input, index);
        let expected = 'Incorrect index';
        assert.equal(result, expected);
    });
    it('Testing input: should return "Incorrect index" if index is bigger than string length', function () {
        let input = 'asdf';
        let index = 4;
        let result = lookupChar(input, index);
        let expected = 'Incorrect index';
        assert.equal(result, expected);
    });
    //Testing the real functionality
    it('Testing input: should return f if ("asdf", 3) is passed in', function () {
        let input = 'asdf';
        let index = 3;
        let result = lookupChar(input, index);
        let expected = 'f';
        assert.equal(result, expected);
    });
});