function solution(num1, num2){

    let sum = 0;
    let a = Number(num1);
    let b = Number(num2);
    while(a <= b){
        sum += a;
        a++;
    }

    return sum;
}

//console.log(solution('-8', '20'));