function solve(arr){
    let steps = arr.pop();

    let resultArr = arr.reduce((acc, el, index) => {
        if (index % steps === 0) {
            acc.push(el);
        }
        return acc;
    }, []);

    console.log(resultArr.join('\n'));
}

// solve(['5', 
// '20', 
// '31', 
// '4', 
// '20', 
// '2']
// );