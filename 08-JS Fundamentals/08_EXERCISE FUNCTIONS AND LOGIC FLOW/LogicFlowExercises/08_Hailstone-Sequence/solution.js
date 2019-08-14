function getNext() {
    
    let number = +document.getElementById('num').value;
    let result = document.getElementById('result');

    result.textContent = hailstone(number).join(' ') + ' '; //this last space is because Judge !!!

    function hailstone (num) {
        let seq = [num];
        while (num > 1) {
            num = num % 2 ? 3 * num + 1 : num / 2;
            seq.push(num);
        }
        return seq;
    }
    
}