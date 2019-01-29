function solve() {

  let textArray = document.getElementById('string').value.split('');
  let resultElement = document.getElementById('result');
  let resultArray = [];

  for (const char of textArray) {
    if (/\s/.test(char)) {
      resultArray.push(char);

    } else if (!resultArray.includes(char)) {
      resultArray.push(char);
    }
  }

  resultElement.textContent = resultArray.join('');
}