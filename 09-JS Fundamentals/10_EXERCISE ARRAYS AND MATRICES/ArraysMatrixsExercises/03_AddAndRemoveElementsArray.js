function solve(arr){
    let resultArr = arr.reduce((acc, el, index) => {
        if (el === 'add') {
            acc.push(index + 1);
        }
        else{
            acc.pop();
        }
        return acc;
    }, []);

    if (resultArr.length === 0) {
        console.log('Empty');
    }
    else{
        console.log(resultArr.join('\n'));
    }
}

// solve(['add', 
// 'add', 
// 'remove', 
// 'add', 
// 'add']
// );