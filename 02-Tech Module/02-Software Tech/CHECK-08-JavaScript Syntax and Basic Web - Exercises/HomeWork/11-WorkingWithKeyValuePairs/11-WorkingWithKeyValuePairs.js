function solution(arr) {
    let result = {};

    for (let i = 0; i < arr.length; i++) {
        let temp = arr[i].split(' ');

        if(temp.length===1){
            if(result.hasOwnProperty(temp[0])){
                console.log(result[temp[0]])
            }
            else{
                console.log("None")
            }
        }
        else{
            result[temp[0]] = temp[1];
        }

    }
}

solution([
    '3 343',
    '3 te3434st1',
    '3'
]);