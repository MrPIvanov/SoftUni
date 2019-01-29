function solve() {

	let element = document.getElementById('exercise');

	setTimeout(randomize, 2000);

	function randomize(){
		
		let margin = (getRndInteger(1, 45)).toString();

		//Dont Know exactly what margin numbers to use. Feel free to change.
		element.style.margin = margin += '%';

		setTimeout(randomize, 2000);
	}

	function getRndInteger(min, max) {
		return Math.floor(Math.random() * (max - min + 1) ) + min;
	  }
}