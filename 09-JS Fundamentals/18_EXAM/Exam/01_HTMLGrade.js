function solve(examPoints, completedHomeworks, totalHomeworks) {

    let bonusHomeworks = (completedHomeworks / totalHomeworks) * 10;

    let examPart = ((examPoints / 400) * 0.9) * 100;

    let totalPoints = examPart + bonusHomeworks;

    let grade = 3 + 2 * (totalPoints - 20) / (50);

    if(grade < 3){
        grade = 2;
    }
    if(grade > 6){
        grade = 6;
    }
    if(examPoints === 400){
        grade = 6;
    }
    console.log(grade.toFixed(2));
}

//solve(400, 0, 5);