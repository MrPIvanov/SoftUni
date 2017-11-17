function solution(arr) {
    let result =[];
    for (let i = 0; i < arr.length; i++) {
       result.unshift(arr[i]);


    }
    console.log(result.join("\n"));
}


solution([
    '10',
    '15',
    '20'

]);