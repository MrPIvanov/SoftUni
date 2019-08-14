function solve() {

  let allText = document.getElementById("input").textContent.split(".");

  console.log(allText);

  let newPar = [];
  for (i = 0; i <= allText.length; i++) {
    if(newPar.length === 3){
      CreateElement(newPar);
      newPar = [];
    }
    newPar.push(allText[i]);
  }

  CreateElement(newPar);

  function CreateElement(newPar){

    let element = document.createElement("p");
    element.textContent = newPar.join(" ");

    let parent = document.getElementById("output");

    parent.appendChild(element);
  }
}