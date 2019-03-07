(function () {
    const Suits = {
        SPADES: '♠',
        HEARTS: '♥',
        DIAMONDS: '♦',
        CLUBS: '♣'
    };
    let validFaces = ["2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"];

    class Card {
        constructor(face, suit) {
            this.face = face;
            this.suit = suit;
        }
        get face() {
            return this._face;
        }
        set face(face) {
            if (validFaces.includes(face)) {
                this._face = face;
            } else {
                throw new Error('Invalid Face!');
            }
        }
        get suit(){
            return this._suit;
        }
        set suit(suit){
            if(Object.values(Suits).includes(suit)){
                this._suit = suit;
            } else {
                throw new Error('Invalid Suit!');
            }
        }
    }

    return {
        Suits: Suits,
        Card: Card
    };
})();