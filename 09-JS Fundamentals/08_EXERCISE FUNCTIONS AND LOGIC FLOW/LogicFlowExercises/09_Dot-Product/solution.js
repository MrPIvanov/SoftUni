function solve() {
	let mat1Element = document.getElementById('mat1');
	let mat2Element = document.getElementById('mat2');

	let resultElement = document.getElementById('result');


	let matrix1 = eval(mat1Element.value);
	let matrix2 = eval(mat2Element.value);

	for (let firstArrIndex = 0; firstArrIndex < matrix1.length; firstArrIndex++) {

		let product = '';
		for (let secondArrIndex = 0; secondArrIndex < matrix2.length; secondArrIndex++) {

			product += multiplyArray(matrix1[firstArrIndex], matrix2[secondArrIndex]);

			if (secondArrIndex !== matrix2.length - 1) {
				product += ', ';
			}

		}
		let resultParagraph = document.createElement('p');
		resultParagraph.textContent = product;
		resultElement.appendChild(resultParagraph);
	}

	function multiplyArray(first, second) {

		let product = 0;

		if (first.length === second.length) {
			for (let index = 0; index < first.length; index++) {
				product += +first[index] * +second[index];
			}
		}

		return product;
	}
}