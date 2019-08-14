function solution(firstString, secondString, thirdString){

    let firstLength = firstString.length;
    let secondLength = secondString.length;
    let thirdLength = thirdString.length;

    let sum = firstLength + secondLength + thirdLength;
    let average = Math.floor(sum / 3);

    console.log(sum);
    console.log(average);
}

//solution('chocolate', 'ice cream', 'cake');