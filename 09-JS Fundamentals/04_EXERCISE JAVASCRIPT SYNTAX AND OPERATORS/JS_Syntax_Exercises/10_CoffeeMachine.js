function solution(arr){

    let totalSum = 0;
    for(i =0; i < arr.length; i++){
        totalSum += processOrder(arr[i].split(", "));
    }

    console.log(`Income Report: ${totalSum.toFixed(2)}$`);

    function processOrder(arr){
        let finalPrice = 0;

        let allMoney = arr[0];
        let drink = arr[1];
        let milkMulti = false;
        let sugarMulti = false;

        if(drink === 'tea'){
             if(arr.length === 4){
                milkMulti = true; 
                if(arr[3] > 0){
                    sugarMulti = true;
                }
             }  
             else{
                if(arr[2] > 0){
                    sugarMulti = true;
                }
             } 

             finalPrice = 0.8;
             if(milkMulti){
                finalPrice+=0.1;
             }
             if(sugarMulti){
                finalPrice+=0.1;
             }
             if(Number(allMoney) >= finalPrice){
                 console.log(`You ordered ${drink}. Price: ${finalPrice.toFixed(2)}$ Change: ${(allMoney - finalPrice).toFixed(2)}$`);
                 return finalPrice;
             }
             else{
                 console.log(`Not enough money for ${drink}. Need ${(finalPrice - allMoney).toFixed(2)}$ more.`);
                 return 0;
             }
        }
        else{
            if(arr.length === 5){
                milkMulti = true; 
                if(arr[4] > 0){
                    sugarMulti = true;
                }
             }  
             else{
                if(arr[3] > 0){
                    sugarMulti = true;
                }
             } 

             finalPrice = 0.8;
             if(arr[2] === "decaf"){
                finalPrice += 0.1;
             }

             if(milkMulti){
                finalPrice+=0.1;
             }
             if(sugarMulti){
                finalPrice+=0.1;
             }
             if(Number(allMoney) >= finalPrice){
                 console.log(`You ordered ${drink}. Price: ${finalPrice.toFixed(2)}$ Change: ${(allMoney - finalPrice).toFixed(2)}$`);
                 return finalPrice;
             }
             else{
                 console.log(`Not enough money for ${drink}. Need ${(finalPrice - allMoney).toFixed(2)}$ more.`);
                 return 0;
             }
        }
    }
}

//solution(['1.00, coffee, caffeine, milk, 4', '0.40, tea, milk, 2',
//'1.00, coffee, decaf, 0']
//);

//solution(['8.00, coffee, decaf, 4',
//'1.00, tea, 2']
//);