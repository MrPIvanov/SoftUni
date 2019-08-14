function solve(arr){

    let resultArr = arr.filter((el , index, arr) => {
        if (el >= arr[Math.max(0, index - 1)]) {
            return true;
        }
        return false;
    });

    console.log(resultArr.join('\n'));
}

// solve([1, 
//     3, 
//     8, 
//     4, 
//     10, 
//     12, 
//     3, 
//     2, 
//     24]
//     );