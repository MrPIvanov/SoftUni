function solution(steps, length, speed){

    let distance = (steps * length) / 1000;

    let restTimeSeconds = (Math.floor(distance / 0.5)) * 60;
    let totalSeconds = (distance / speed) * 60 * 60;
    totalSeconds += restTimeSeconds;
    let hours =  Math.floor(totalSeconds / 3600);
    totalSeconds = totalSeconds % 3600;
    let mins = Math.floor(totalSeconds / 60);
    totalSeconds = totalSeconds % 60;


    hours = hours >= 10 ? hours.toFixed(0).toString() : '0' + hours.toFixed(0).toString();
    mins = mins >= 10 ? mins.toFixed(0).toString() : '0' + mins.toFixed(0).toString();
    totalSeconds = totalSeconds >= 10 ? totalSeconds.toFixed(0).toString() : '0' + totalSeconds.toFixed(0).toString();

    console.log(`${hours}:${mins}:${totalSeconds}`)
}

//solution(4000, 0.60, 5);
//solution(2564, 0.70, 5.5);