function solution(arr, workDays){
    let calories;
    if(arr[0] === "f"){
        calories = 655 + 9.7 * Number(arr[1]) + 1.85 * Number(arr[2]) - 4.7 * Number(arr[3]);
    }
    else{
        calories = 66 + 13.8 * Number(arr[1]) + 5 * Number(arr[2]) - 6.8 * Number(arr[3]);
    }

    let AF;
    switch(workDays){
        case 0: AF = 1.2; break;
        case 1: AF = 1.375; break;
        case 2: AF = 1.375; break;
        case 3: AF = 1.55; break;
        case 4: AF = 1.55; break;
        case 5: AF = 1.55; break;
        case 6: AF = 1.725; break;
        case 7: AF = 1.725; break;
        default : AF = 1.9; break;
    }

    let allCalories = AF * calories;

    console.log(`${allCalories.toFixed(0)}`);
}

//solution(['f', 46, 157, 32], 5);
//solution(['m', 86, 185, 25], 3);