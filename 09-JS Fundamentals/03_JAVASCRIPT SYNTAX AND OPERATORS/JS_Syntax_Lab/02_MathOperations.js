function solution(num1, num2, operator){

    switch(operator){
        case "+": return num1 + num2;
        case "-": return num1 - num2;
        case "*": return num1 * num2;
        case "/": return num1 / num2;
        case "%": return num1 % num2;
        case "**": return Math.pow(num1, num2);
    }


}

//console.log(solution(2, 4, '**'));