function solution(text) {

    let words = text.split(",").join("").split(".").join("").split(" ");

    let numbers = [];

    for (let word of words) {

        if (!isNaN(word)) {
            numbers.push(Number(word));
        }
    }

    for (let number of numbers) {

        let result = String(number);

        if (result.endsWith("1")) {
            console.log(`${result}st`);
        }
        else if (result.endsWith("2")) {
            console.log(`${result}nd`);
        }
        else if (result.endsWith("3")) {
            console.log(`${result}rd`);
        }
        else {
            console.log(`${result}th`);
        }
    }
}

//solution('The school has 256 students. In each class there are 26 chairs, 13 desks and 1 board.');
//solution('Yesterday I bought 12 pounds of peppers, 3 kilograms of carrots and 5 kilograms of tomatoes.');