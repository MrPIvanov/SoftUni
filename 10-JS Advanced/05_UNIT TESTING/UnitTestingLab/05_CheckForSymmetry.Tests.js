//const assert = require('chai').assert;
//const isSymmetric = require('./05_CheckForSymmetry');

describe('isSymmetric', function(){
    it('Past string shoud return false', function(){
        let input = 'rrrrr';

        assert.equal(isSymmetric(input), false);

    });

    it('Past object shoud return false', function(){
        let input = {};

        assert.equal(isSymmetric(input), false);

    });

    it('Past number shoud return false', function(){
        let input = 5;

        assert.equal(isSymmetric(input), false);

    });

    it('Past corect array shoud return true', function(){
        let input = [4, 4, 4];

        assert.equal(isSymmetric(input), true);

    });

    it('Past non symmetric array shoud return false', function(){
        let input = [4, 4, 4, 5];

        assert.equal(isSymmetric(input), false);

    });

    it('Past empty array shoud return true', function(){
        let input = [];

        assert.equal(isSymmetric(input), true);

    });

    it('Past array with 1 element shoud return true', function(){
        let input = [1];

        assert.equal(isSymmetric(input), true);

    });

    it('with elements of different types, should return false', function () {
        let input = [1, '2', 3, 2, 1];

        assert.equal(isSymmetric(input), false);
    });
});