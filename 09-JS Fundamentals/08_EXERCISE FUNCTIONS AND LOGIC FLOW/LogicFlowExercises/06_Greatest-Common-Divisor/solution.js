function greatestCD() {
    
    let firstNumber = +document.getElementById('num1').value;
    let secondNumber = +document.getElementById('num2').value;
    let resultElement = document.getElementById('result');
    let result = 0;

    for (let index = 1; index <= Math.max(firstNumber, secondNumber); index++) {
        if(firstNumber % index === 0 && secondNumber % index === 0){
            result = index;
        }
    }  
    
    resultElement.textContent = result;
}