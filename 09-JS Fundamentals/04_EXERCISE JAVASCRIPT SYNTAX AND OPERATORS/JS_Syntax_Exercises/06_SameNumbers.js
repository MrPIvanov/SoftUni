function solution(number){
    var sum = 0;
    let same = true;

    for (let index = 0; index < String(number).length; index++) {
        let element = Number(String(number)[index]);
        sum +=element;

        if(Number(String(number)[index]) !== Number(String(number)[0])){
            same = false;
        }
    }

    console.log(same);
    console.log(sum);
}

//solution(2222222);
//solution(1234);