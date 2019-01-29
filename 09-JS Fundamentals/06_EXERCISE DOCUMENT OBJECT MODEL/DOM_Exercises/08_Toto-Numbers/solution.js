function solve() {
	
	let input = document.getElementsByTagName('input')[0];

	let btn = document.getElementsByTagName('button')[0].addEventListener('click', function () {
		let words = input.value.split(' ');
		let numbers = [];
		words.forEach(w => {
			numbers.push(+w);
		});

		let isCorrect = true;

		if(numbers.length !== 6){
			isCorrect = false;
		}

		for (const num of numbers) {
			if(num < 1 || num > 49 || isNaN(num)){
				isCorrect = false;
			}
		}
		
		if(isCorrect){
			let element = document.getElementById('allNumbers');

			for(i = 1; i < 50; i++){
				let current = document.createElement('div');
				current.textContent = i;
				current.className += 'numbers';

				if(numbers.includes(i)){
					current.style.background = 'orange';
				}

				element.appendChild(current);
			}

			let inputElement = document.getElementsByTagName('input')[0];
			let btnElement = document.getElementsByTagName('button')[0];
	
			inputElement.disabled = 'true';
			btnElement.disabled = 'true';
		}
	});
}