function solve() {
   
   let num = +document.getElementById('num').value;
   let result = document.getElementById('result');
   let resultArray = [];

   for (let index = 1; index <= num; index++) {
      
      if(num % index === 0){
         resultArray.push(index);
      }
   }

   result.textContent = resultArray.join(' ');

}