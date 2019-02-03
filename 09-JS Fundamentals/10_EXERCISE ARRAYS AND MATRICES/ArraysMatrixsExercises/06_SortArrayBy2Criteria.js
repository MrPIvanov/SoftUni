function solve(arr){
    arr.sort((a, b) => {
        if (a.length === b.length) {
            return a.toLowerCase() > b.toLowerCase();
        }
        else{
            return a.length - b.length;
        }
    });

    console.log(arr.join('\n'));
}

// solve(['alpha', 
// 'beta', 
// 'gamma']
// );