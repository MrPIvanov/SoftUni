function solve() {
  
  let number = +document.getElementById('num').value;
  let input = document.getElementById('arr');
  let result = document.getElementById('result');

  let arr = JSON.parse(input.value);

  let resultArr = [];

  for (let index = 0; index < arr.length; index++) {

    console.log(arr[index]);
    let i = arr[index].indexOf(number);
    resultArr.push(`${i >= 0} -> ${i}`);
  }

  result.textContent = resultArr.join(',');
}