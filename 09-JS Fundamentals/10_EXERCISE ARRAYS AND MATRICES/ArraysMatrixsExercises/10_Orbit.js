function solve(input) {
    let side = input[0];
    let targetRow = input[2];
    let targetCol = input[3];

    let matrix = [];

    for (let index = 0; index < side; index++) {
        matrix[index] = [];
    }

    for (let row = 0; row < side; row++) {
        for (let col = 0; col < side; col++) {
            
            let distance = Math.max(Math.abs(targetRow - row), Math.abs(targetCol - col)) + 1;
            matrix[row][col] = distance;
        }
    }

    //Print
    for (let index = 0; index < matrix.length; index++) {
        console.log(matrix[index].join(' '));
    }
}

//solve([4, 4, 0, 0]);