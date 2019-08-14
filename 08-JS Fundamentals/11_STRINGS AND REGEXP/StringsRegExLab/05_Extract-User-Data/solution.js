function solve() {

  let arr = JSON.parse(document.getElementById('arr').value);
  let resultElement = document.getElementById('result');

  let regExPattern = /^([A-Z][a-z]* [A-Z][a-z]*) (\+359 [0-9]{1} [0-9]{3} [0-9]{3}|\+359-[0-9]{1}-[0-9]{3}-[0-9]{3}) ([a-z0-9]+@[a-z]+\.[a-z]{2,3})$/;

  arr.forEach(text => {
    if (regExPattern.test(text)) {
      let match = regExPattern.exec(text);
      CreateAndAppendElement(`Name: ${match[1]}`);
      CreateAndAppendElement(`Phone Number: ${match[2]}`);
      CreateAndAppendElement(`Email: ${match[3]}`);
    } else {
      let invalidDataElement = document.createElement('p');
      invalidDataElement.textContent = 'Invalid data';
      resultElement.appendChild(invalidDataElement);
    }

    let dashElement = document.createElement('p');
    dashElement.textContent = '- - -';
    resultElement.appendChild(dashElement);
  });

  function CreateAndAppendElement(textToAppend) {
    let element = document.createElement('p');
    element.textContent = textToAppend;
    resultElement.appendChild(element);
  }
}