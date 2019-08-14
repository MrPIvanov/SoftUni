function solution(num1, num2){

    let result = 1;

    for(i = 2; i <= Math.min(num1, num2); i++){

        if(num1 % i === 0 && num2 % i === 0 && i > result){
            result = i;
        }
    }

    console.log(result);
}

//solution(15, 5);
//solution(2154, 458);