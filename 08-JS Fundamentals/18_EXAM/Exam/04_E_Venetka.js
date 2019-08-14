function solve(input) {
    let townProfit = {};
    let townVinete = {};
    //Get Town Profit and Vinete Registered
    for (let index = 0; index < input.length; index++) {
        let currentTown = input[index].town;
        let currentPrice = input[index].price;

        if (!townProfit.hasOwnProperty(currentTown)) {
            townProfit[currentTown] = 0;
            townVinete[currentTown] = 0;
        }
        townProfit[currentTown] += currentPrice;
        townVinete[currentTown]++;
    }

    //Add TotalProfitProp and total vinete
    for (let index = 0; index < input.length; index++) {

        input[index].totalProfit = townProfit[input[index].town];
        input[index].totalVinete = townVinete[input[index].town];
    }

    input.sort((a, b) => {
        if (a.totalProfit == b.totalProfit) {
            if (a.townVinete == b.totalVinete) {
                return a.town.localeCompare(b.town);
            } else {
                return b.townVinete - a.totalVinete;
            }
        } else {
            return b.totalProfit - a.totalProfit;
        }
    });

    let distinctTowns = removeDuplicates(input, 'town');

    distinctTowns.sort((a, b) => {
        if (a.totalProfit == b.totalProfit) {
            if (a.townVinete == b.totalVinete) {
                return a.town.localeCompare(b.town);
            } else {
                return b.townVinete - a.totalVinete;
            }
        } else {
            return b.totalProfit - a.totalProfit;
        }
    });

    let mostProfitTown = distinctTowns[0].town;
    let mostProfit = distinctTowns[0].totalProfit;
    let firstLine = `${mostProfitTown} is most profitable - ${mostProfit} BGN`;


    let dataForCars = input.filter(x => x.town == mostProfitTown);

    let carsCount = {};
    let carsMaxPrice = {};
    //Get 
    for (let index = 0; index < dataForCars.length; index++) {
        let currentCar = dataForCars[index].model;
        let currentPrice = dataForCars[index].price;

        if (!carsCount.hasOwnProperty(currentCar)) {
            carsCount[currentCar] = 0;
            carsMaxPrice[currentCar] = 0;
        }
        carsMaxPrice[currentCar] += Math.max(currentPrice, carsMaxPrice[currentCar]);
        carsCount[currentCar]++;
    }

    //Add
    for (let index = 0; index < dataForCars.length; index++) {

        dataForCars[index].totalOccur = carsCount[dataForCars[index].model];
        dataForCars[index].maxVinetePrice = carsMaxPrice[dataForCars[index].model];
    }

    dataForCars.sort((a,b) => {
        if(a.totalOccur == b.totalOccur){
            if(a.maxVinetePrice == b.maxVinetePrice){
                 return a.model.localeCompare(b.model);   
            }
            else{
                return b.maxVinetePrice - a.maxVinetePrice;
            }
        }
        else{
            return b.totalOccur - a.totalOccur;
        }
    });

    let mostDrivenModel = dataForCars[0].model;
    let secondLine = `Most driven model: ${mostDrivenModel}`;


    let finalData = input.filter(x => x.model == mostDrivenModel);

    let townPlate = {};

    for (let index = 0; index < finalData.length; index++) {
        let currentTown = finalData[index].town;

        if(!townPlate.hasOwnProperty(currentTown)){
            townPlate[currentTown] = [];
        }

        townPlate[currentTown].push(finalData[index].regNumber);
    }

    let sortedFinal = Object.keys(townPlate).sort((a, b) => a.localeCompare(b));

    console.log(firstLine);
    console.log(secondLine);
    for (let index = 0; index < sortedFinal.length; index++) {
        console.log(`${sortedFinal[index]}: ${townPlate[sortedFinal[index]].sort((a, b) => {
            return a.localeCompare(b);
        }).join(', ')}`);
        
    }
    
    function removeDuplicates(myArr, prop) {
        return myArr.filter((obj, pos, arr) => {
            return arr.map(mapObj => mapObj[prop]).indexOf(obj[prop]) == pos;
        });
    }
}

// solve([{
//         model: 'BMW',
//         regNumber: 'B1234SM',
//         town: 'Varna',
//         price: 2
//     },
//     {
//         model: 'BMW',
//         regNumber: 'C5959CZ',
//         town: 'Sofia',
//         price: 8
//     },
//     {
//         model: 'Tesla',
//         regNumber: 'NIKOLA',
//         town: 'Burgas',
//         price: 9
//     },
//     {
//         model: 'BMW',
//         regNumber: 'A3423SM',
//         town: 'Varna',
//         price: 3
//     },
//     {
//         model: 'Lada',
//         regNumber: 'SJSCA',
//         town: 'Sofia',
//         price: 3
//     }
// ]);