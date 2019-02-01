function solve() {
  
  let input = document.getElementById('arr');
  let result = document.getElementById('result');

  let arr = JSON.parse(input.value);

  let resultArr = [];

  for (let index = 0; index < arr.length; index++) {
    
    let resultStr = arr[index].split('').reverse().join('');
    resultStr = resultStr.charAt(0).toUpperCase() + resultStr.slice(1);
    resultArr.push(resultStr);
  }

  result.textContent = resultArr.join(' ');
}