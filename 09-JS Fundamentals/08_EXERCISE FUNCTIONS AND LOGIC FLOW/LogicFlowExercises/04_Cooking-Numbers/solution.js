function solve() {
    
    let allBtn = document.querySelectorAll('#operations button');

    let chopBtn = allBtn[0].addEventListener('click', chop);
    let diceBtn = allBtn[1].addEventListener('click', dice);
    let spiceBtn = allBtn[2].addEventListener('click', spice);
    let bakeBtn = allBtn[3].addEventListener('click', bake);
    let filletBtn = allBtn[4].addEventListener('click', fillet);

    let input = document.querySelector('main div input');
    let currentValue = 0;
    let result = document.getElementById('output');
    let alreadyTakeInput = false;

    

    function chop(){
        if(!alreadyTakeInput && input.value.length > 0){
            currentValue = +input.value;
            alreadyTakeInput = true;
        }

        currentValue = currentValue / 2;
        result.textContent = currentValue;
    }

    function dice(){

        if(!alreadyTakeInput && input.value.length > 0){
            currentValue = +input.value;
            alreadyTakeInput = true;
        }

        currentValue = Math.sqrt(currentValue);
        result.textContent = currentValue;
    }

    function spice(){

        if(!alreadyTakeInput && input.value.length > 0){
            currentValue = +input.value;
            alreadyTakeInput = true;
        }

        currentValue = currentValue + 1;
        result.textContent = currentValue;
    }

    function bake(){

        if(!alreadyTakeInput && input.value.length > 0){
            currentValue = +input.value;
            alreadyTakeInput = true;
        }

        currentValue = currentValue * 3;
        result.textContent = currentValue;
    }

    function fillet(){

        if(!alreadyTakeInput && input.value.length > 0){
            currentValue = +input.value;
            alreadyTakeInput = true;
        }

        currentValue = currentValue * 0.8;
        result.textContent = currentValue;
    }
}
