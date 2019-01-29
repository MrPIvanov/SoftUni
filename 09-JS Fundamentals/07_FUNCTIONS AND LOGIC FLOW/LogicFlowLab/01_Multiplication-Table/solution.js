function solve() {
  let resultDiv = document.getElementById('result');
  resultDiv.textContent = '';
  let num1Element = document.getElementById('num1');
  let num2Element = document.getElementById('num2');

  let num1 = +num1Element.value;
  let num2 = +num2Element.value;

  if (num1 < num2) {
    for (i = num1; i <= num2; i++) {
      let current = document.createElement('p');
      current.textContent = `${i} * ${num2} = ${i * num2}`;
      resultDiv.appendChild(current);
    }
  } else {
    resultDiv.textContent = 'Try with other numbers.';
  }
}