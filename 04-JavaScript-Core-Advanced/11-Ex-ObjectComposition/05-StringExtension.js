(function(){
    String.prototype.ensureStart = function(str){
        if (!this.startsWith(str)){
        // if (this.indexOf(str) > 0 || this.indexOf(str) < 0){
            return str + this;
        }
        return '' + this;
    };

    String.prototype.ensureEnd = function(str){
        if (!this.endsWith(str)){
            return this + str;
        }
        return this + '';
    };

    String.prototype.isEmpty = function () {
        if(this.length === 0){
            return true;
        }
        return false;
    };

    String.prototype.truncate = function (n) {
        if (n < 4){
            return '.'.repeat(n);
        }
        if(this.length <= n){
            return '' + this;
        }
        if (this.indexOf(' ') < 0){
            return this.substring(0, n-3) + '...';
        }

        let workStr = this;
        while(true){
            workStr = workStr.substring(0, workStr.lastIndexOf(' '));
            console.log(`${workStr}: length = ${workStr.length}`);
            if (workStr.length + 3 <= n){
                return workStr + '...';
            }
        }
    };

    String.format = function () {
        let string = arguments[0];
        for (let i = 1; i < arguments.length; i++) {
            let regex = new RegExp('\\{' + (i - 1) + '}', 'g');
            string = string.replace(regex, arguments[i]);
        }
        return string;
    };

}());

// let str = 'the quick brown fox jumps over the lazy dog';
// str = str.ensureEnd(' dog');
// str = str.ensureEnd(' dog');
// str = str.truncate(20);
str = String.format('The {0} {1} fox', 'quick', 'brown');
console.log(str)