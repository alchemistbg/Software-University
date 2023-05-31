class Textbox {
    constructor(selector, regex) {
        this._elements = $(selector);
        this._value = $(this._elements).eq(0).val();
        this._invalidSymbols = regex;
        this.onInput();
    }

    get elements() {
        return this._elements;
    }

    get value() {
        return this._value;
    }

    set value(v) {
        this._value = v;
        for (let elem of this.elements) {
            $(elem).val(v);
        }
    }

    onInput() {
        this.elements.on('input', (event) => {
            let text = $(event.target).val();
            this.value = text;
        });

    }


    isValid() {
        return !this._invalidSymbols.test(this.value);
    }
}

let textbox = new Textbox(".textbox", /[^a-zA-Z0-9]/);
let inputs = $('.textbox');

inputs.on('input', function () {
    console.log(textbox.value);
});
