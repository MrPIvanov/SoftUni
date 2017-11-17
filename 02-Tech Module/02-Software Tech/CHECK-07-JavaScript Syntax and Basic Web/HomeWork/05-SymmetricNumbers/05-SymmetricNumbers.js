function solution([input]) {
    let number = Number(input);

    for (let i = 1; i <= number; i++) {

        if (i.toString() === i.toString().split('').reverse().join('')) {
            console.log(i)
        }

    }
}

solution(['100'])