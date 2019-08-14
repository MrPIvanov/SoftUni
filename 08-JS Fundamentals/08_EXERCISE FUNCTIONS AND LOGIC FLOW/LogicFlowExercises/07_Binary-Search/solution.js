function binarySearch() {

    let inputArray = document.getElementById('arr').value.split(', ').map(Number);
    let number = +document.getElementById('num').value;
    let result = document.getElementById('result');
    
    let searchResult = binarySearch(inputArray, number);

    if(searchResult === -1){
        result.textContent = `${number} is not in the array`;
    }
    else{
        result.textContent = `Found ${number} at index ${searchResult}`;
    }


    function binarySearch(array, value) {
        let guess = 0;
        let min = 0;
        let max = array.length - 1;

        while (min <= max) {
            guess = Math.floor((min + max) / 2);
            if (array[guess] === value)
                return guess;
            else if (array[guess] < value)
                min = guess + 1;
            else
                max = guess - 1;
        }

        return -1;
    }
}