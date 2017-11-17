function solution(arr) {
    let result = [];
    let temp = {};

    for (let i = 0; i < arr.length; i++) {
        temp = JSON.parse(arr[i])
        result.push(temp)

    }
    result.forEach(x=>console.log(`Name: ${x.name}\r\nAge: ${x.age}\r\nDate: ${x.date}`))
}

solution([
    '{"name":"Gosho","age":10,"date":"19/06/2005"}',
    '{"name":"Tosho","age":11,"date":"04/04/2005"}'

]);