function solve() {

  let textToDecode = document.getElementById('str').value;
  let resultElement = document.getElementById('result');

  let sum = textToDecode.split('').map(Number).reduce((a, b) => a + b, 0);

  while (sum > 9) {
    let textSum = String(sum);
    sum = textSum.split('').map(Number).reduce((a, b) => a + b, 0);
  }

  let textToWork = textToDecode.slice(sum);
  textToWork = textToWork.slice(0, (sum * -1));
  let numbers = textToWork.match(/.{1,8}/g);

  let chars = numbers.map(n => parseInt(n, 2));
  let result = '';

  for (const ch of chars) {
    let charToAdd = String.fromCharCode(ch);
    if (charToAdd.match(/[a-z]/i) || charToAdd === ' ') {
      result += charToAdd;
    }
  }

  resultElement.textContent = result;
}