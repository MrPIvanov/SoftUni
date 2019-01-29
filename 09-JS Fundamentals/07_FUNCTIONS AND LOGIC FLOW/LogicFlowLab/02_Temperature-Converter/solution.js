function solve() {
  
  let resultElement = document.getElementById('result');
  let numberElement = document.getElementById('num1');
  let textElement = document.getElementById('type');

  resultElement.textContent = '';

  let num = +numberElement.value;
  let text = textElement.value.toLowerCase();

  if(text === 'celsius'){
    let result = (((num * 9) / 5) + 32).toFixed(0);
    resultElement.textContent = result;
  }
  else if(text === 'fahrenheit'){
    let result = (((num - 32) * 5) / 9).toFixed(0);
    resultElement.textContent = result;
  }
  else{
    resultElement.textContent = 'Error!';
  }
}