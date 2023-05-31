let expect = require('chai').expect;
let Console = require('../specialConsole').Console;

describe("Console.writeLine(string)", function () {
    it("Console.writeLine(string) -> string", function () {
        let string = "Bla bla bla";
        expect(Console.writeLine(string)).to.equal(string);
    });
    it("Console.writeLine(Object) -> JSON.stringify(Object)", function () {
        let object = {property: "property"};
        expect(Console.writeLine(object)).to.equal(JSON.stringify(object))
    });
    it("Console.writeLine() -> TypeError", function () {
        expect(() => Console.writeLine()).to.throw(TypeError);
    });
    it("Console.writeLine(1, 2) -> TypeError", function () {
        expect(() => Console.writeLine(1, 2)).to.throw(TypeError)
    });
    it("Console.writeLine('{0}.', '1','2') -> RangeError", function () {
        let string = "{0}.";
        expect(() => Console.writeLine(string, '1', '2')).to.throw(RangeError);
    });
    it("Console.writeLine('{0}{0}.', '1','2') -> RangeError", function () {
        let string = "{0}{0}.";
        expect(() => Console.writeLine(string, '1', '2')).to.throw(RangeError);
    });
    it("Console.writeLine('{0}{1}.', '1','2') -> '12'", function () {
        let string = "{0}{1}.";
        expect(Console.writeLine(string, '1', '2')).to.equal("12.");
    });
    it("Console.writeLine('{0}{1}{2}', '1','2') -> RangeError", function () {
        let string = "{0}{1}{2}";
        expect(() => Console.writeLine(string, '1', '2')).to.throw(RangeError);
    });
    it("Console.writeLine('{3}', '1') -> RangeError", function () {
        expect(() => Console.writeLine("{3}", '1')).to.throw(RangeError);
    });
});