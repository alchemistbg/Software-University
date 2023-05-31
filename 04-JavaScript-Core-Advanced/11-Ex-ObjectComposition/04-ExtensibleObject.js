function solve() {
    let obj = {};

    obj.extend = function (template) {

        let templateProps = Object.keys(template);
        templateProps.forEach((prop) => {
            if (typeof template[prop] == 'function'){
                Object.getPrototypeOf(this)[prop] = template[prop];
            }else{
                this[prop] = template[prop];
            }
        });

    };
    return obj;
}

let template = {
    extensionMethod: function () {

    },
    extensionProperty: 'someString'
}

let myObj = solve();
myObj.extend(template);