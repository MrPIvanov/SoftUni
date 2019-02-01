function solve() {
  
  let input = document.getElementById('arr');
  let result = document.getElementById('result');

  let arr = JSON.parse(input.value);

  let resultArr = [];

  for (let index = 0; index < arr.length; index++) {
    
    if(index % 2 === 0){  
      resultArr.push(arr[index]);
    }
  }

  result.textContent = resultArr.join(' x ');
}