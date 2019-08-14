function solution(num1, num2, num3){

    let result = Math.max(Math.max(num1, num2), num3);

    console.log(`The largest number is ${result}.`);
}

//solution(5, -3, 16);