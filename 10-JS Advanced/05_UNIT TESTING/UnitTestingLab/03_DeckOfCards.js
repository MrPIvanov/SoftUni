function printDeckOfCards(arr) {
    function makeCard(face, suit) {
        let validFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    
        let validSuits = {
            S: '\u2660',
            H: '\u2665',
            D: '\u2666',
            C: '\u2663'
        };
    
        if (!validFaces.includes(face) || !validSuits.hasOwnProperty(suit)) {
            throw new Error('Invalid card');
        }
    
        let card = {
            face: face,
            suit: suit,
            toString: function () {
                return this.face + validSuits[this.suit];
            }
        };
    
        return card;
    }

    let result = [];

    for (const item of arr) {
        let suit = item.slice(-1);
        let face = item.slice(0, -1);

        let card = {};
        try {
            card = makeCard(face, suit);
            result.push(card);

        } catch (error) {
            console.log(`Invalid card: ${face + suit}`);
            return;
        }
    }

    console.log(result.join(' '));
    return;
}

//printDeckOfCards(['AS', '10D', 'KH', '2C']);
//printDeckOfCards(['5S', '3D', 'QD', '1C']);