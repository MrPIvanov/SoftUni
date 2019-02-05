function solve() {

    let resultElement = document.getElementById('result');
    let text = document.getElementById('str').value;

    let numbers = [];
    let words = text
        .split(' ')
        .filter(x => x != '')
        .forEach(word => {
            if (isNaN(word)) {

                let chars = word.split('')
                    .map(ch => ch.charCodeAt(0))
                    .join(' ');

                let pElement = document.createElement('p');
                pElement.textContent = chars;
                resultElement.appendChild(pElement);
            } else {
                numbers.push(word);
            }
        });

        let pElement = document.createElement('p');
        pElement.textContent = numbers.map(n => String.fromCharCode(n)).join('');
        resultElement.appendChild(pElement);  
}