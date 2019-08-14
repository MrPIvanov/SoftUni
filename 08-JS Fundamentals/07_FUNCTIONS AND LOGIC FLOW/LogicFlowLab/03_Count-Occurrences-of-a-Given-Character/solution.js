function solve() {
  
  let text = document.getElementById('string').value.split('');
  let character = document.getElementById('character').value;

  let count = 0;

  for (const char of text) {
    if(char === character){
      count++;
    }
  }

  let resultElement = document.getElementById('result');

  if(count % 2 === 0 ){
    resultElement.textContent = `Count of ${character} is even.`;
  }
  else{
    resultElement.textContent = `Count of ${character} is odd.`;
  }
}