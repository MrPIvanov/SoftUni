function solution(arr) {
    let result = {};
    let finalKey;

    for (let i = 0; i < arr.length; i++) {
        let temp = arr[i].split(' ');

        if(temp.length===1){
            if(result.hasOwnProperty(temp[0])){

            }
            else{
                console.log("None")
                return;
            }
        }
        else{
            if(result.hasOwnProperty(temp[0])){
                result[temp[0]].push(temp[1]);

            }
            else{
                result[temp[0]]=[];
                result[temp[0]].push(temp[1])
            }
        }

    finalKey = temp[0];
    }
    console.log(result[finalKey].join('\r\n'))
}

solution([
    '3 test',
    '3 test1',
    '4 test2',
    '4 test3',
    '4 test5',
    '4'
]);