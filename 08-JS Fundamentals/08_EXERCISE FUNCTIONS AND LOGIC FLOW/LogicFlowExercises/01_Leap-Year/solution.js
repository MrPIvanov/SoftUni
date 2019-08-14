function leapYear() {
    let btn = document.querySelector('main div button');
    btn.addEventListener('click', checkForLeapYear);

    function checkForLeapYear() {
        let input = document.querySelector('main div input');
        let yearValue = +input.value;
        let isLeap = leapYearFunc(yearValue);

        let div = document.querySelector('#year div');
        div.textContent = yearValue;
        let h2 = document.querySelector('#year h2');
        input.value = '';

        if(isLeap){
            h2.textContent = 'Leap Year';
        }
        else{
            h2.textContent = 'Not Leap Year';
        }
    }

    function leapYearFunc(year) {
        return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
    }
}