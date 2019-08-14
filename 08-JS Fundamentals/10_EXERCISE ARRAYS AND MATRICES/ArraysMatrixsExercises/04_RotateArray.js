function solve(arr){
    let rotations = arr.pop();
    for (let index = 0; index < rotations % arr.length; index++) {
        let element = arr.pop();
        arr.unshift(element);        
    }
    console.log(arr.join(' '));
}

// solve(['1', 
// '2', 
// '3', 
// '4', 
// '2']
// );