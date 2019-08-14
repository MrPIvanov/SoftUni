function solve() {
  
  let input = document.getElementById('arr');
  let result = document.getElementById('result');

  let arr = eval(input.value);

  for (let index = 0; index < arr.length; index++) {
    
    let currentP = document.createElement('p');

    currentP.textContent = `${index} -> ${arr[index] * arr.length}`;
    result.appendChild(currentP);
  }
}