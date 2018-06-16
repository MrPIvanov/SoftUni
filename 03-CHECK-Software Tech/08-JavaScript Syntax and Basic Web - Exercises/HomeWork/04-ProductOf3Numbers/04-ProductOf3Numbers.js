function solution(nums) {
    let num1 = Number(nums[0]);
    let num2 = Number(nums[1]);
    let num3 = Number(nums[2]);

    if (num1 ===0 ||num2===0||num3===0){
        console.log('Positive');
    }
    else{
        let counter = 0;
        if (num1<0){
            counter++;
        }
        if(num2<0){
            counter++;
        }
        if (num3<0){
            counter++;
        }
        if (counter%2===0){
            console.log('Positive');
        }
        else{
            console.log('Negative');

        }
    }

}

solution([
    '2',
    '3',
    '-1'
]);