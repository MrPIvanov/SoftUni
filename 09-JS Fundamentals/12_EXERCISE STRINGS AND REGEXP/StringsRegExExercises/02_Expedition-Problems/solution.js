function solve() {
  let keyWord = document.getElementById('str').value;
  let text = document.getElementById('text').value;

  let messagePattern = new RegExp(keyWord + "(.+)" + keyWord);

  let message = text.match(messagePattern)[1];

  let coordinatesPattern = /(north|east).*?([0-9]{2})[^,]*?,[^,]*?([0-9]{6})/gmi;

  let arrCoordinates = [];

  while ((temp = coordinatesPattern.exec(text)) !== null) {
    arrCoordinates.push(temp[1] + ' ' + temp[2] + '.' + temp[3]);
  }

  let nCord = '';
  let eCord = '';

  while (!nCord || !eCord) {

    let current = arrCoordinates.pop();

    if (current[0].toLowerCase() === 'n' && !nCord) {
      nCord = current;
    }

    if (current[0].toLowerCase() === 'e' && !eCord) {
      eCord = current;
    }
  }

  let resultElement = document.getElementById('result');

  CreateAndAppendElement(`${nCord.split(' ')[1]} N`);
  CreateAndAppendElement(`${eCord.split(' ')[1]} E`);
  CreateAndAppendElement(`Message: ${message}`);

  function CreateAndAppendElement(text) {
    let element = document.createElement('p');
    element.textContent = text;
    resultElement.appendChild(element);
  }
}