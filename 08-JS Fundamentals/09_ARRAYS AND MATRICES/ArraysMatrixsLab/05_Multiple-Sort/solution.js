function solve() {
  
  let input = document.getElementById('arr');
  let result = document.getElementById('result');

  let arr = JSON.parse(input.value);

  let ascending = document.createElement('div');
  ascending.textContent = arr.sort(function(a, b)
  {return Number(a) - Number(b);}
  ).join(', ');
  result.appendChild(ascending);

  let alphabetically = document.createElement('div');
  alphabetically.textContent = arr.sort().join(', ');
  result.appendChild(alphabetically);
}