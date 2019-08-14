function solve(input) {

    //Transform input to number matrix
    let matrix = [];
    for (let index = 0; index < input.length; index++) {
        let currentRow = input[index].split(' ').map(x => Number(x));
        matrix[index] = currentRow;
    }

    let firstSum = 0;
    let secondSum = 0;
    for (let index = 0; index < matrix.length; index++) {
        firstSum += matrix[index][index];
        secondSum += matrix[matrix.length - 1 - index][matrix.length - 1 - index];
    }

    if (firstSum === secondSum) {
        changeMatrix(matrix);
    }

    //Print
    for (let index = 0; index < matrix.length; index++) {
        console.log(matrix[index].join(' '));
    }

    function changeMatrix(matrix) {
        for (let row = 0; row < matrix.length; row++) {
           for (let col = 0; col < matrix[row].length; col++) {
               if (row !== col && row + col !== matrix.length - 1) {
                   matrix[row][col] = firstSum;
               }
           }
            
        }
    }
}

// solve(['5 3 12 3 1',
//     '11 4 23 2 5',
//     '101 12 3 21 10',
//     '1 4 5 2 2',
//     '5 22 33 11 1'
// ]);