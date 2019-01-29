function solve() {
  let resultElement = document.getElementById('result');

  let firstNumber = +document.getElementById('firstNumber').value;
  let secondNumber = +document.getElementById('secondNumber').value;
  let firstString = document.getElementById('firstString').value;
  let secondString = document.getElementById('secondString').value;
  let thirdString = document.getElementById('thirdString').value;

  for (let index = firstNumber; index <= secondNumber; index++) {
    let current = document.createElement('p');
    let text = '';

    if(index % 3 === 0 && index % 5 === 0){
      text = `${index} ${firstString}-${secondString}-${thirdString}`;
    }
    else if(index % 3 === 0){
      text = `${index} ${secondString}`;
    }
    else if(index % 5 === 0){
      text = `${index} ${thirdString}`;
    }
    else{
      text = `${index}`;
    }
    current.textContent = text;

    resultElement.appendChild(current);
  }
}