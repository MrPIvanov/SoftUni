function solve() {

  let resultElement = document.getElementById('result');
  let firstString = document.getElementById('str1').value;
  let secondString = document.getElementById('str2').value;

  let text = firstString
    .toLowerCase()
    .split(' ')
    .filter(x => x != '')
    .map(x =>
      x.charAt(0).toUpperCase() + x.slice(1)
    )
    .join('');

  if(secondString == 'Camel Case'){
    resultElement.textContent = text.charAt(0).toLowerCase() + text.slice(1);
  }  

  else if(secondString == 'Pascal Case'){
    resultElement.textContent = text;
  }

  else{
    resultElement.textContent = 'Error!';
  }
}