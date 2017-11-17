function solution(arr) {
    let numbers = arr.map(Number);
    numbers.sort((a, b) => b - a);
    for (let i = 0; i < Math.min(3,numbers.length); i++) {
        let obj = numbers[i];
        console.log(obj);

    }

}


solution([
    '10', '30', '15', '20', '50', '5'
]);