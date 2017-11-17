function solution(num){
    let a = Number(num[0]);
    let b = Number(num[1]);
    if (a>b){
        console.log(a/b);
    }
    else{
        console.log(a*b);
    }
}

solution([
    '3',
    '2'
]);