function solve() {
    
    let btn = document.querySelector('#exercise button');
    btn.addEventListener('click', addCards);

    let cards = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A',];

    function addCards(){
        let result = document.getElementById('cards');
        let from = document.getElementById('from');
        let to = document.getElementById('to');
        let type = document.querySelector('#exercise select');

        let startIndex = cards.indexOf(from.value);
        let endIndex = cards.indexOf(to.value);

        let selectOption = type.options[type.selectedIndex].value;
        let suit = selectOption[selectOption.length - 1];

        for (let index = startIndex; index <= endIndex; index++) {    

            let firstP = document.createElement('p');
            firstP.textContent = suit;

            let secondP = document.createElement('p');
            secondP.textContent = cards[index];

            let thirdP = document.createElement('p');
            thirdP.textContent = suit;

            let div = document.createElement('div');
            div.classList.add('card');
            div.appendChild(firstP);
            div.appendChild(secondP);
            div.appendChild(thirdP);

            result.appendChild(div);
        }
    }
}