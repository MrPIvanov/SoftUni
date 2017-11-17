function solution(arr) {
    for (let i = 0; i < arr.length; i++) {
        if(arr[i]==='Stop'){
            break;
        }
        console.log(arr[i])

    }
}


solution([
    'Line 1',
    'Line 2',
    'Line 3',
    'Stop'

]);