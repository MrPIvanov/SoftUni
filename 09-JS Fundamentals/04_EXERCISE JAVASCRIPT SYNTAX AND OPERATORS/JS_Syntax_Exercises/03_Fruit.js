function solution(fruit, grams, price){

    console.log(`I need ${((grams / 1000) * price).toFixed(2)} leva to buy ${(grams / 1000).toFixed(2)} kilograms ${fruit}.`);
}

//solution('apple', 1563, 2.35);