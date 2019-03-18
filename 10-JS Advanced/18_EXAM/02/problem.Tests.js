const assert = require('chai').assert;
const FilmStudio = require('./filmStudio');


describe('Film Studio', function () {
    it('constructor', function () {

        let studio = new FilmStudio('Pesho');

        assert.isArray(studio.films);
        assert.isEmpty(studio.films);
        assert.equal(studio.name, 'Pesho');
    });

    it('invalid constructor', function () { // Maybe no string ?????

        let studio = new FilmStudio([1, 2, 3]);

        assert.isArray(studio.films);
        assert.isEmpty(studio.films);
        assert.deepEqual(studio.name, [1, 2, 3]);
    });

    it('makeMovie', function () {

        let studio = new FilmStudio('Pesho');

        assert.throws(() => studio.makeMovie('test'), "Invalid arguments count");
    });

    it('makeMovie', function () {

        let studio = new FilmStudio('Pesho');

        assert.throws(() => studio.makeMovie('test'), "Invalid arguments count");
    });


    it('makeMovie', function () {

        let studio = new FilmStudio('Pesho');

        assert.throws(() => studio.makeMovie('test', 'test 2'), "Invalid arguments");
    });

    it('makeMovie', function () {

        let studio = new FilmStudio('Pesho');

        assert.throws(() => studio.makeMovie([1, 2, 3], 'test 2'), "Invalid arguments");
    });

    it('makeMovie last', function () {

        let studio = new FilmStudio('Pesho');

        assert.throws(() => studio.makeMovie({}, [1, 2, 3]), "Invalid arguments");
    });

    it('makeMovie last', function () {

        let studio = new FilmStudio('Pesho');

        assert.throws(() => studio.makeMovie('tes', 4), "Invalid arguments");
    });

    it('makeMovie last', function () {

        let studio = new FilmStudio('Pesho');

        assert.throws(() => studio.makeMovie({}, [2, 3]), "Invalid arguments");
    });

    it('makeMovie corect', function () {

        let studio = new FilmStudio('Pesho');

        let result = studio.makeMovie('Test', [1, 2, 3]);

        assert.equal(result.filmName, 'Test');
        assert.equal(result.filmRoles.length, 3);
        assert.equal(studio.films.length, 1);
    });

    it('makeMovie corect', function () {

        let studio = new FilmStudio('Pesho');

        let result = studio.makeMovie('Test', [1, 2, 3]);
        let result2 = studio.makeMovie('Test', [1, 2, 3, 4, 5]);

        assert.equal(result.filmName, 'Test');
        assert.equal(result2.filmName, 'Test 2');
        assert.equal(result.filmRoles.length, 3);
        assert.equal(result2.filmRoles.length, 5);
        assert.equal(studio.films.length, 2);
    });

    it('makeMovie corect', function () {

        let studio = new FilmStudio('Pesho');

        let result = studio.makeMovie('Test', [1, 2, 3]);

        assert.isObject(result);
        assert.isString(result.filmName);
        assert.isArray(result.filmRoles);

    });


    it('casting corect', function () {

        let studio = new FilmStudio('Pesho');

        studio.makeMovie('Test', [1, 2, 3]);

        let result = studio.casting('Pes', 1);

        assert.equal(result, 'You got the job! Mr. Pes you are next 1 in the Test. Congratz!');

    });

    it('casting no films', function () {

        let studio = new FilmStudio('Pesho');

        let result = studio.casting('Pes', 1);

        assert.equal(result, 'There are no films yet in Pesho.');

    });

    it('casting no role', function () {

        let studio = new FilmStudio('Pesho');

        studio.makeMovie('Test', [1, 2, 3]);

        let result = studio.casting('Pes', 4);
        let result2 = studio.casting('Pesoooo', 4);

        assert.equal(result, 'Pes, we cannot find a 4 role...');
        assert.equal(result2, 'Pesoooo, we cannot find a 4 role...');

    });

    it('casting no role', function () {

        let studio = new FilmStudio('Pesho');

        studio.makeMovie('Test', [1, 2, 3]);

        let result = studio.casting('Pes', 3);
        let result2 = studio.casting('Pesoooo', 3);

        assert.equal(result, 'You got the job! Mr. Pes you are next 3 in the Test. Congratz!');
        assert.equal(result2, 'You got the job! Mr. Pesoooo you are next 3 in the Test. Congratz!');

    });

    // it('lookForProducer', function () {

    //     let studio = new FilmStudio('Pesho');

    //     assert.throws(() => studio.casting(), Error);
    // });

    it('lookForProducer', function () {

        let studio = new FilmStudio('Pesho');

        studio.makeMovie('Test', [1]);

        let result = studio.lookForProducer('Test');

        assert.equal(result, 'Film name: Test\nCast:\nfalse as 1\n');

    });

    it('lookForProducer', function () {

        let studio = new FilmStudio('Pesho');

        assert.throws(() => studio.lookForProducer(), "undefined do not exist yet, but we need the money...");
    });

    it('lookForProducer', function () {

        let studio = new FilmStudio('Pesho');

        studio.makeMovie('Test', [1]);

        assert.throws(() => studio.lookForProducer('Testttt'), "Testttt do not exist yet, but we need the money...");
    });

    it('combine', function () {

        let filmStudio = new FilmStudio('SU-Studio');

        let result1 = filmStudio.makeMovie('The Avengers', ['Iron-Man', 'Thor', 'Hulk', 'Arrow guy']);
        let result2 = filmStudio.makeMovie('The Avengers', ['Iron-Man', 'Hulk', 'Arrow guy', 'Ant-man']);
        let result3 = filmStudio.makeMovie('The New Avengers', ['Iron-Man', 'Thor', 'Hulk', 'Arrow guy', 'Black Panther']);

        let result4 = filmStudio.casting('Pesho', 'Thor');
        let result5 = filmStudio.casting('Peshoo', 'Ant-man');
        let result6 = filmStudio.casting('Peshoo', 'Iron-Man');

        let result7 = filmStudio.lookForProducer('The Avengers');
        let result8 = filmStudio.lookForProducer('The Avengers 2');

        assert.equal(result1.filmName, 'The Avengers');
        assert.equal(result2.filmName, 'The Avengers 2');
        assert.equal(result3.filmName, 'The New Avengers');
        assert.equal(result4, 'You got the job! Mr. Pesho you are next Thor in the The Avengers. Congratz!');
        assert.equal(result5, 'You got the job! Mr. Peshoo you are next Ant-man in the The Avengers 2. Congratz!');
        assert.equal(result6, 'You got the job! Mr. Peshoo you are next Iron-Man in the The Avengers. Congratz!');
        assert.equal(result7, 'Film name: The Avengers\nCast:\nPeshoo as Iron-Man\nPesho as Thor\nfalse as Hulk\nfalse as Arrow guy\n');
        assert.equal(result8, 'Film name: The Avengers 2\nCast:\nfalse as Iron-Man\nfalse as Hulk\nfalse as Arrow guy\nPeshoo as Ant-man\n');

    });
});