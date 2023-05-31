let assert = require('chai').assert;
let jsdom = require('jsdom-global')();
let $ = require('jquery');

function nuke(selector1, selector2) {
    if (selector1 === selector2) {
        return;
    }
    $(selector1).filter(selector2).remove();
}

describe('', function () {

    beforeEach(function () {
        document.body.innerHTML = `
            <!DOCTYPE html>
            <html lang="en">
            <script src="chai-jquery.js"></script>
            <head>
                <meta charset="UTF-8">
                <title>ArmageDOM</title>
            </head>
            <body>
            <div id="target">
                <div class="nested target">
                    <p>This is some text</p>
                </div>
                <div class="target">
                    <p>Empty div</p>
                </div>
                <div class="inside">
                    <span class="nested">Some more text</span>
                    <span class="target">Some more text</span>
                </div>
            </div>
            </body>
            </html>`
    });

    it('should ', function () {
        let expect = $('body').html();
        nuke('p');
        let result = $('body').html();
        assert.equal(result, expect, '');
    });

    it('should ', function () {
        let expect = $('body').html();
        nuke(5, 'p');
        let result = $('body').html();
        assert.equal(result, expect, '');
    });

    it('should ', function () {
        let expect = $('body').html();
        nuke('p', {});
        let result = $('body').html();
        assert.equal(result, expect, '');
    });

    it('should ', function () {
        let expect = $('body').html();
        nuke('', 'p');
        let result = $('body').html();
        assert.equal(result, expect, '');
    });

    it('should ', function () {
        let expect = $('body').html();
        nuke({}, {});
        let result = $('body').html();
        assert.equal(result, expect, '');
    });

    it('should ', function () {
        let expect = $('body').html();
        nuke('p', 'p');
        let result = $('body').html();
        assert.equal(result, expect, '');
    });

    it('should ', function () {
        let s1 = '#target';
        let s2 = '.nested';
        nuke(s1, s2);
        let result = $('#target .nested').length;
        assert.equal(result, 2);
    });

    it('should ', function () {
        let s1 = 'div';
        let s2 = '.target';
        nuke(s1, s2);
        let result = $('div .target').length;
        assert.equal(result, 1);
    });
});