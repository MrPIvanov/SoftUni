function solution(arr) {
    let obj = {};
    let str;
    for (let i = 0; i < arr.length; i++) {
        let temp = arr[i].split(' -> ')
        let prop = temp[0];
        let val = temp[1];
        if(Number.isNaN(Number(val))){
            val = temp[1];
        }
        else{
            val = Number(temp[1]);

        }
        obj[prop] = val;
    }
     str = JSON.stringify(obj);
    console.log(str)

}

solution([
    'name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995',
    'town -> Sofia'
]);