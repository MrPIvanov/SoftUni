function solve() {
	let title = document.getElementById("createTitle");
	let text = document.getElementById("createContent");

	let titleValue = title.value;
	let textValue = text.value;

	title.value = "";
	text.value = "";

	if(titleValue.length > 0 && textValue.length > 0){

		let mainElement = document.getElementById("articles");
		let article = document.createElement("article");
		let newTitle = document.createElement("h3");
		newTitle.textContent = titleValue;
		let newText = document.createElement("p");
		newText.textContent = textValue;
		article.appendChild(newTitle);
		article.appendChild(newText);
		mainElement.appendChild(article);
	}
}