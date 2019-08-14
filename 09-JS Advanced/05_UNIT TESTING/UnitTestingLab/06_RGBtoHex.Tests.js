//const rgbToHexColor = require('./06_RGBtoHex');
//const assert = require('chai').assert;

describe('rgbToHexColor', function(){
    it('past corect values shoud return corect', function(){
        let num1 = 23;
        let num2 = 33;
        let num3 = 43;
        
        assert.equal(rgbToHexColor(num1, num2, num3), '#17212B');
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = -23;
        let num2 = 33;
        let num3 = 43;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 2223;
        let num2 = 33;
        let num3 = 43;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 23;
        let num2 = -33;
        let num3 = 43;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 23;
        let num2 = 4433;
        let num3 = 43;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 23;
        let num2 = 33;
        let num3 = -43;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 23;
        let num2 = 33;
        let num3 = 4443;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 23.3;
        let num2 = 33;
        let num3 = 44;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 23;
        let num2 = 33.3;
        let num3 = 44;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 23;
        let num2 = 33;
        let num3 = 44.7;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 23;
        let num2 = 33;
        let num3 = '44';
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = '23';
        let num2 = 33;
        let num3 = 44;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 23;
        let num2 = '33';
        let num3 = 44;
        
        assert.equal(rgbToHexColor(num1, num2, num3), undefined);
    });

    it('past incorect values shoud return undefined', function(){
        let num1 = 23;
        let num2 = 33;
        
        assert.equal(rgbToHexColor(num1, num2), undefined);
    });

    it('result shoud start with "#"', function(){
        let num1 = 0;
        let num2 = 0;
        let num3 = 0;
        
        assert.equal(rgbToHexColor(num1, num2, num3)[0], '#');
    });

    it('result shoud be correct', function(){
        let num1 = 0;
        let num2 = 0;
        let num3 = 0;
        
        assert.equal(rgbToHexColor(num1, num2, num3), '#000000');
    });

    it('result shoud be correct', function(){
        let num1 = 255;
        let num2 = 255;
        let num3 = 255;
        
        assert.equal(rgbToHexColor(num1, num2, num3), '#FFFFFF');
    });
});