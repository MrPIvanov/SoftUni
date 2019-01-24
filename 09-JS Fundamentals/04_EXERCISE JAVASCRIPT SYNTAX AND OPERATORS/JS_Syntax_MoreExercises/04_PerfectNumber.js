function solution(arr){

    let resultArray = [];

    for (const number of arr) {
        if(testForPerfectNumber(number)){
            resultArray.push(number);
        }
    }


    if(resultArray.length === 0){
        console.log("No perfect number");
    }
    else{
        console.log(resultArray.join(", "));
    }


    function testForPerfectNumber(number){
        let currentSum = 0;

       for(i = 1; i <= number; i++){
           if(number % i === 0){
               currentSum += i;
           }
       }

       if(number * 2 === currentSum){
           return true;
       }
       return false;
    }
}

//solution([5, 6, 28]);
//solution([5, 32, 82]);