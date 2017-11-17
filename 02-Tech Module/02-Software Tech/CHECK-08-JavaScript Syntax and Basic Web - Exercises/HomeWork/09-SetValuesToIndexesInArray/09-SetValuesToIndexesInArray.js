function solution(arr) {
    let numberOfElements = Number(arr[0]);
    let result = new Array(numberOfElements);

    for (let i = 0; i < result.length; i++) {
       result[i]=0;

    }
    for (let i = 1; i < arr.length; i++) {
       let temp = arr[i].split(" - ");
       let index = temp[0];
       let value = temp[1];
       result[index]= value;
    }
    console.log(result.join("\n"));
}

solution([
    '2',
    '0 - 5',
    '0 - 6',
    '0 - 7'
]);