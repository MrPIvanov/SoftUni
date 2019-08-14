function solve() {
  
  let arr = JSON.parse(document.getElementById('arr').value);
  let replaceWord = document.getElementById('str').value;
  let resultElement = document.getElementById('result');

  let wordToBeReplaced = arr[0].split(' ')[2];

  let regExPattern = new RegExp(wordToBeReplaced, "gi");

  arr.forEach(w => {
    let textToPrint = w.replace(regExPattern, replaceWord);
    let element = document.createElement('p');
    element.textContent = textToPrint;
    resultElement.appendChild(element);
  });
}