function solve() {
    let selectOptionsElement = document.getElementById("selectMenuTo");
    let binaryOption = document.createElement("option");
    let hexadecimalOption = document.createElement("option");

    binaryOption.textContent = "Binary";
    binaryOption.value = "binary";
    hexadecimalOption.textContent = "Hexadecimal";
    hexadecimalOption.value = "hexadecimal";

    selectOptionsElement.appendChild(binaryOption);
    selectOptionsElement.appendChild(hexadecimalOption);

    let btn = document.querySelector('button');

    btn.addEventListener('click', function () {

        let inputElement = document.getElementById('input');
        let resultElement = document.getElementById('result');

        if(selectOptionsElement.value === 'binary'){
           resultElement.value = (+inputElement.value).toString(2);

        } else {
            resultElement.value = (+inputElement.value).toString(16).toUpperCase();
        }
    });
}