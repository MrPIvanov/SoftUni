function solve() {
	let correctAnswers = 0;
	let currentSection = 0;

	let rightAnswers = {
		'softUniYear': '2013',
		'popularName': 'Pesho',
		'softUniFounder': 'Nakov'
	};

	let sections = document.getElementsByTagName('section');
	let btns = Array.from(document.getElementsByTagName('button')).forEach(btn => {
		btn.addEventListener('click', function (){
				let isChecked = false;

				let parent = this.parentElement;

				let labels = parent.querySelectorAll('input');

				for (const label of labels) {
					if(label.checked){
						isChecked = true;
						if(label.value === rightAnswers[label.name]){
							correctAnswers++;
						}
						break;
					}
				}

				if(isChecked && currentSection !== 2){
					sections[++currentSection].style.display = 'block';
				}
				else{
					let result = document.getElementById('result');
					if(correctAnswers === 3){
						result.textContent = 'You are recognized as top SoftUni fan!';
					}
					else{
						result.textContent = `You have ${correctAnswers} right answers`;
					}
				}
		});
	});
}