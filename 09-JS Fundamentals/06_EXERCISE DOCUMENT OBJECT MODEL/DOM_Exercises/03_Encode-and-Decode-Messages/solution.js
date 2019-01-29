function solve() {

	let allBtn = document.querySelectorAll("div button");

	let encodeButton = allBtn[0];
	let decodeButton = allBtn[1];

	encodeButton.addEventListener("click", encode);
	decodeButton.addEventListener("click", decode);

	function encode() {
		let msgElement = document.querySelectorAll("div textarea")[0];
		let msg = msgElement.value;
		msgElement.value = "";

		let displayElement = document.querySelectorAll("div textarea")[1];

		displayElement.textContent = transformMsg(msg, 1);
	}

	function decode() {
		let msgElement = document.querySelectorAll("div textarea")[1];
		let msg = msgElement.value;

		msgElement.textContent = transformMsg(msg, -1);
	}

	function transformMsg(msg, number){
		let result = [];
		msg = msg.split("");

		for (const letter of msg) {
			result.push(String.fromCharCode((letter.charCodeAt() + number)));
		}

		return result.join("");
	}	
}