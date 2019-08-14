function solve(arr, commandInput) {
    let result = [];
    let firstRow = arr[0];
    let data = arr.slice(1);
    commandInput = commandInput.split(" ");
    let command = commandInput[0];
    let header = commandInput[1];
    if (command === 'sort') {

        let colIndex = firstRow.indexOf(header);

        result = sortByColumn(data, colIndex);

        print(result);

    } else if (command === 'hide') {

        let colIndex = firstRow.indexOf(header);

        firstRow.splice(colIndex, 1);

        for (let row = 0; row < data.length; row++) {
            data[row].splice(colIndex, 1);
        }

        print(data);

    } else if (command === 'filter') {
        let value = commandInput[2];
        let colIndex = firstRow.indexOf(header);

        for (let row = 0; row < data.length; row++) {
            if(data[row][colIndex] === value){
                result.push(data[row]);
            }
            
        }
        print(result);
    }

    function sortByColumn(a, colIndex) {

        a.sort(sortFunction);

        function sortFunction(a, b) {
            if (a[colIndex] === b[colIndex]) {
                return 0;
            } else {
                return (a[colIndex] < b[colIndex]) ? -1 : 1;
            }
        }

        return a;
    }

    function print(result) {

        console.log(firstRow.join(' | '));
        for (let row = 0; row < result.length; row++) {

            console.log(result[row].join(' | '));
        }
    }
}

// solve([['firstName', 'age', 'grade', 'course'],
// ['Peter', '25', '5.00', 'JS-Core'],
// ['George', '34', '6.00', 'Tech'],
// ['Marry', '28', '5.49', 'Ruby']],
// 'filter firstName Marry'
// );