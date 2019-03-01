//const assert = require('chai').assert;
//const createCalculator = require('./07_AddSubtract');

describe('createCalculator', function(){
    it('keep the initial sum', function(){
        let obj = createCalculator();

        assert.equal(obj.get(), 0);
    });

    it('keep the initial sum after operation', function(){
        let number = 5;
        let obj = createCalculator();
        obj.add(number);

        assert.equal(obj.get(), 5);
    });

    it('keep the initial sum after operation', function(){
        let number = 5;
        let obj = createCalculator();
        obj.subtract(number);

        assert.equal(obj.get(), -5);
    });

    it('keep the initial sum after operation', function(){
        let number = -5;
        let obj = createCalculator();
        obj.add(number);

        assert.equal(obj.get(), -5);
    });

    it('keep the initial sum after operation', function(){
        let number = -5;
        let obj = createCalculator();
        obj.subtract(number);

        assert.equal(obj.get(), 5);
    });

    it('check for properties shoud return true', function(){
        let obj = createCalculator();

        assert.equal(obj.hasOwnProperty('add'), true);
    });

    it('check for properties shoud return true', function(){
        let obj = createCalculator();

        assert.equal(obj.hasOwnProperty('subtract'), true);
    });

    it('check for properties shoud return true', function(){
        let obj = createCalculator();

        assert.equal(obj.hasOwnProperty('get'), true);
    });

    it('keep the initial sum after operation with string', function(){
        let number = '5';
        let obj = createCalculator();
        obj.subtract(number);

        assert.equal(obj.get(), -5);
    });

    it('keep the initial sum after operation with string', function(){
        let number = '5';
        let obj = createCalculator();
        obj.add(number);

        assert.equal(obj.get(), 5);
    });

    it('wrong input shoud return NaN', function(){
        let number = '5rrree';
        let obj = createCalculator();
        obj.add(number);

        assert(isNaN(obj.get()));
    });

    it('wrong input shoud return NaN', function(){
        let number;
        let obj = createCalculator();
        obj.subtract(number);

        assert(isNaN(obj.get()));
    });

    it('return type is object', function(){
        let result = createCalculator();

        assert.isObject(result, `Result is not a object`);
      });

    it('return obj which does not contain internal sum', function () {
        let result = createCalculator();

        assert.notProperty(result, 'value');
    });

    it('return obj which does not contain internal sum', function () {
        let result = createCalculator();

        assert.notProperty(result, 'value', 'Returned object contain property value');
    });
    it('return obj which does not contain internal sum', function () {
        let result = createCalculator();
        let num = '10';
        result.add(num);
        result.add(num);

        assert.equal(result.get(), 20, `Result must be a 20, but is a ${result.get()}`);
    });
});