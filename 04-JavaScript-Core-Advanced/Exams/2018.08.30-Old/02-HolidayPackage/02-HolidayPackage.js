        let assert = require('chai').assert;

class HolidayPackage {
    constructor(destination, season) {
        this.vacationers = [];
        this.destination = destination;
        this.season = season;
        this.insuranceIncluded = false; // Default value
    }

    showVacationers() {
        if (this.vacationers.length > 0)
            return "Vacationers:\n" + this.vacationers.join("\n");
        else
            return "No vacationers are added yet";
    }

    addVacationer(vacationerName) {
        if (typeof vacationerName !== "string" || vacationerName === ' ') {
            throw new Error("Vacationer bookName must be a non-empty string");
        }
        if (vacationerName.split(" ").length !== 2) {
            throw new Error("Name must consist of first bookName and last bookName");
        }
        this.vacationers.push(vacationerName);
    }

    get insuranceIncluded() {
        return this._insuranceIncluded;
    }

    set insuranceIncluded(insurance) {
        if (typeof insurance !== 'boolean') {
            throw new Error("Insurance status must be a boolean");
        }
        this._insuranceIncluded = insurance;
    }

    generateHolidayPackage() {
        if (this.vacationers.length < 1) {
            throw new Error("There must be at least 1 vacationer added");
        }
        let totalPrice = this.vacationers.length * 400;

        if (this.season === "Summer" || this.season === "Winter") {
            totalPrice += 200;
        }

        totalPrice += this.insuranceIncluded === true ? 100 : 0;

        return "Holiday Package Generated\n" +
            "Destination: " + this.destination + "\n" +
            this.showVacationers() + "\n" +
            "Price: " + totalPrice;
    }
}

describe('', function () {
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        assert.instanceOf(testClass, HolidayPackage);
    });
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        assert.typeOf(testClass.destination, 'string');
        assert.typeOf(testClass.season, 'string');
        assert.equal(testClass.destination, 'Italy');
        assert.equal(testClass.season, 'Summer');
        //assert.typeOf(testClass.vacationers, 'Array');
        //assert.equal(testClass.vacationers.length, 0);
        //assert.equal(testClass.insuranceIncluded, false);
    });
    // it('should ', function () {
    //     let testClass = new HolidayPackage('Italy', 'Summer');
    //     assert.property(testClass, 'showVacationers');
    //     assert.property(testClass, 'addVacationer');
    //     assert.property(testClass, 'generateHolidayPackage');
    // });

    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        let result = testClass.showVacationers();
        let expect = 'No vacationers are added yet';
        assert.equal(result, expect);
    });
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        testClass.addVacationer('Kiro Spirov');
        let result = testClass.showVacationers();
        let expect = 'Vacationers:\nKiro Spirov';
        assert.equal(result, expect);
    });
    //test addVacationer errors
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        assert.throws(function() { testClass.addVacationer(5) }, Error, 'Vacationer bookName must be a non-empty string');
    });
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        assert.throws(function() { testClass.addVacationer(' ') }, Error, 'Vacationer bookName must be a non-empty string');
    });
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        assert.throws(function() { testClass.addVacationer('Ko Shi Yam') }, Error, 'Name must consist of first bookName and last bookName');
    });
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        assert.throws(function() { testClass.addVacationer('KoShiYam') }, Error, 'Name must consist of first bookName and last bookName');
    });
    //test set insuranceIncluded errors
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        assert.throws(function() { testClass.insuranceIncluded = 'true'}, Error, 'Insurance status must be a boolean');
    });
    //
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        assert.throws(function() { testClass.generateHolidayPackage()}, Error, 'There must be at least 1 vacationer added');
    });

    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        testClass.addVacationer('Kiro Spirov');
        let result = testClass.generateHolidayPackage();
        let expect = 'Holiday Package Generated\nDestination: Italy\nVacationers:\nKiro Spirov\nPrice: 600';
        assert.equal(result, expect);
    });
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Winter');
        testClass.addVacationer('Kiro Spirov');
        let result = testClass.generateHolidayPackage();
        let expect = 'Holiday Package Generated\nDestination: Italy\nVacationers:\nKiro Spirov\nPrice: 600';
        assert.equal(result, expect);
    });
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Spring');
        testClass.addVacationer('Kiro Spirov');
        let result = testClass.generateHolidayPackage();
        let expect = 'Holiday Package Generated\nDestination: Italy\nVacationers:\nKiro Spirov\nPrice: 400';
        assert.equal(result, expect);
    });
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Spring');
        testClass.addVacationer('Kiro Spirov');
        testClass.insuranceIncluded = true;
        let result = testClass.generateHolidayPackage();
        let expect = 'Holiday Package Generated\nDestination: Italy\nVacationers:\nKiro Spirov\nPrice: 500';
        assert.equal(result, expect);
    });
    it('should ', function () {
        let testClass = new HolidayPackage('Italy', 'Summer');
        testClass.addVacationer('Kiro Spirov');
        testClass.insuranceIncluded = true;
        let result = testClass.generateHolidayPackage();
        let expect = 'Holiday Package Generated\nDestination: Italy\nVacationers:\nKiro Spirov\nPrice: 700';
        assert.equal(result, expect);
    });

    describe('', function () {
        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            assert.instanceOf(testClass, HolidayPackage);
        });
        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            assert.typeOf(testClass.destination, 'string');
            assert.typeOf(testClass.season, 'string');
            assert.equal(testClass.destination, 'Italy');
            assert.equal(testClass.season, 'Summer');
            //assert.typeOf(testClass.vacationers, 'Array');
            //assert.equal(testClass.vacationers.length, 0);
            //assert.equal(testClass.insuranceIncluded, false);
        });
        // it('should ', function () {
        //     let testClass = new HolidayPackage('Italy', 'Summer');
        //     assert.property(testClass, 'showVacationers');
        //     assert.property(testClass, 'addVacationer');
        //     assert.property(testClass, 'generateHolidayPackage');
        // });

        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            let result = testClass.showVacationers();
            let expect = 'No vacationers are added yet';
            assert.equal(result, expect);
        });
        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            testClass.addVacationer('Kiro Spirov');
            let result = testClass.showVacationers();
            let expect = 'Vacationers:\nKiro Spirov';
            assert.equal(result, expect);
        });
        //test addVacationer errors
        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            assert.throws(function() { testClass.addVacationer(5) }, Error, 'Vacationer bookName must be a non-empty string');
        });
        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            assert.throws(function() { testClass.addVacationer(' ') }, Error, 'Vacationer bookName must be a non-empty string');
        });
        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            assert.throws(function() { testClass.addVacationer('Ko Shi Yam') }, Error, 'Name must consist of first bookName and last bookName');
        });
        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            assert.throws(function() { testClass.addVacationer('KoShiYam') }, Error, 'Name must consist of first bookName and last bookName');
        });
        //test set insuranceIncluded errors
        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            assert.throws(function() { testClass.insuranceIncluded = 'true'}, Error, 'Insurance status must be a boolean');
        });
        //
        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            assert.throws(function() { testClass.generateHolidayPackage()}, Error, 'There must be at least 1 vacationer added');
        });

        // it('should ', function () {
        //     let testClass = new HolidayPackage('Italy', 'Summer');
        //     testClass.addVacationer('Kiro Spirov');
        //     let result = testClass.generateHolidayPackage();
        //     let expect = 'Holiday Package Generated\nDestination: Italy\nVacationers:\nKiro Spirov\nPrice: 600';
        //     assert.equal(result, expect);
        // });
        // it('should ', function () {
        //     let testClass = new HolidayPackage('Italy', 'Winter');
        //     testClass.addVacationer('Kiro Spirov');
        //     let result = testClass.generateHolidayPackage();
        //     let expect = 'Holiday Package Generated\nDestination: Italy\nVacationers:\nKiro Spirov\nPrice: 600';
        //     assert.equal(result, expect);
        // });
        // it('should ', function () {
        //     let testClass = new HolidayPackage('Italy', 'Spring');
        //     testClass.addVacationer('Kiro Spirov');
        //     let result = testClass.generateHolidayPackage();
        //     let expect = 'Holiday Package Generated\nDestination: Italy\nVacationers:\nKiro Spirov\nPrice: 400';
        //     assert.equal(result, expect);
        // });
        it('should ', function () {
            let testClass = new HolidayPackage('Italy', 'Summer');
            testClass.addVacationer('Kiro Spirov');
            testClass.addVacationer('Spiro Spirov');
            testClass.addVacationer('Spiro Kirov');
            testClass.insuranceIncluded = true;
            let result = testClass.generateHolidayPackage();
            let expect = 'Holiday Package Generated\nDestination: Italy\nVacationers:\n' +
                'Kiro Spirov\n' +
                'Spiro Spirov\n' +
                'Spiro Kirov\n' +
                'Price: 1500';
            assert.equal(result, expect);
        });
    });
});