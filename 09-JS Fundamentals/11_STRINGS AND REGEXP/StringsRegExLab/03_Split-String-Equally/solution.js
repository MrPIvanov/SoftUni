function solve() {

    let number = +document.getElementById('num').value;
    let text = document.getElementById('str').value;
    let resultElement = document.getElementById('result');

    let index = 0;
    let words = [];

    while (index + number <= text.length) {
        let currentPart = text.substr(index, number);
        words.push(currentPart);
        index += number;
    }

    if (text.length < number) {
        text += text;
    }

    if (index != text.length) {
        text += words[0];
        let currentPart = text.substr(index, number);
        words.push(currentPart);
    }

    resultElement.textContent = words.join(' ');
}