function solution(amount, arr){

    let resultArray = [];

    arr = arr.sort(function(a, b) {return b - a;});

    while(amount > 0){
        var coin = arr[0];
        if(amount >= coin){
            resultArray.push(coin);
            amount -= coin;
        }
        else{
            arr.shift();
        }
    }

    console.log(resultArray.join(", "));
}

//solution(46, [10, 25, 5, 1, 2]);
//solution(123, [5, 50, 2, 1, 10]);