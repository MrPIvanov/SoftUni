function solution(arr1, arr2, arr3){

    let allNumbers = {};

    for (let index = 0; index < arr1.length; index++) {
        if(allNumbers[arr1[index]] == undefined){
            allNumbers[arr1[index]] = 1;
        }
        else{
            allNumbers[arr1[index]]++;
        }
    }

    for (let index = 0; index < arr2.length; index++) {
        if(allNumbers[arr2[index]] == undefined){
            allNumbers[arr2[index]] = 1;
        }
        else{
            allNumbers[arr2[index]]++;
        }
    }

    for (let index = 0; index < arr3.length; index++) {
        if(allNumbers[arr3[index]] == undefined){
            allNumbers[arr3[index]] = 1;
        }
        else{
            allNumbers[arr3[index]]++;
        }
    }

    let resultNumbers = [];

    for (const key in allNumbers) {
        if(allNumbers[key] === 3){
            resultNumbers.push(Number(key));
        }
    }

    console.log(`The common elements are ${resultNumbers.join(", ")}.`);

    let sum = 0;
    for (const iterator of resultNumbers) {
        sum += iterator;
    }
    console.log(`Average: ${sum / resultNumbers.length}.`);


    function median(values){
        values.sort(function(a,b){
        return a-b;
      });
    
      if(values.length ===0) return 0
    
      var half = Math.floor(values.length / 2);
    
      if (values.length % 2)
        return values[half];
      else
        return (values[half - 1] + values[half]) / 2.0;
    }

    console.log(`Median: ${median(resultNumbers)}.`);
}

//solution([5, 6, 50, 10, 1, 2],
         //[5, 4, 8, 50, 2, 10], 
         //[5, 2, 50]
         //);

//solution([1, 2, 3, 4, 5],
         //[3, 2, 1, 5, 8],
         //[2, 5, 3, 1, 16]
         //);