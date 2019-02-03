function solve(matrix){
    let magicSum = matrix[0].reduce((a, b) => a + b);
    let isMagic = true;

    for (let index = 0; index < matrix.length; index++) {
        let currentSum = matrix[index].reduce((a, b) => a + b);
        if(currentSum !== magicSum){
            isMagic = false;
        }
    }

    for (let col = 0; col < matrix.length; col++) {
        let currentSum = matrix.map(value => value[col]).reduce((a, b) => a + b);
        if(currentSum !== magicSum){
            isMagic = false;
        }
    }

    console.log(isMagic);
}

// solve([[11, 32, 45],
//     [21, 0, 1],
//     [21, 1, 1]]   
//    );