function solution(arr) {
    let result = [];

    for (let i = 0; i < arr.length; i++) {
        let temp = arr[i].split(' ');
        let comand = temp[0];
        let value = temp[1];

        if(comand==="add"){
            result.push(value)
        }

        else if (comand==="remove"){
            if(value>=result.length){
                continue;
            }
            result.splice(value,1)
        }
    }
    console.log(result.join('\r\n'))
}

solution([
    'add 3',
    'add 5',
    'remove 2',
    'remove 0',
    'add 7'
]);