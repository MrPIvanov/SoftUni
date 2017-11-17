function solution(arr) {
    let result = {};

    for (let i = 0; i < arr.length; i++) {
        let temp = arr[i].split(' -> ');
        let name = temp[0];
        let age = temp[1];
        let grade = temp[2];

        result.Name = name;
        result.Age = age;
        result.Grade = grade;

        console.log(`Name: ${result.Name}`)
        console.log(`Age: ${result.Age}`)
        console.log(`Grade: ${result.Grade}`)
    }
}

solution([
    'Pesho -> 13 -> 6.00',
    'Ivan -> 12 -> 5.57',
    'Toni -> 13 -> 4.90'
]);