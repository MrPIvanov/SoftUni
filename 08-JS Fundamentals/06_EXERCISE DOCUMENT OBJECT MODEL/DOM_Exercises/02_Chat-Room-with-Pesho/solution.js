function solve() {

    let allBtn = Array.from(document.getElementsByTagName("button"));

    let myBtn = allBtn[0];
    let peshoBtn = allBtn[1];

    myBtn.addEventListener("click", myClick);
    peshoBtn.addEventListener("click", peshoClick);

    function myClick() {

        let spanElement = document.createElement("span");
        let pElement = document.createElement("p");

        spanElement.textContent = "Me";

        pElement.textContent = document.getElementById("myChatBox").value;

        let divElement = document.createElement("div");
        divElement.appendChild(spanElement);
        divElement.appendChild(pElement);
        divElement.style.textAlign = "left";
        document.getElementById("chatChronology").appendChild(divElement);

        document.getElementById("myChatBox").value = "";
    }

    function peshoClick() {
        let spanElement = document.createElement("span");
        let pElement = document.createElement("p");

        spanElement.textContent = "Pesho";

        pElement.textContent = document.getElementById("peshoChatBox").value;

        let divElement = document.createElement("div");
        divElement.appendChild(spanElement);
        divElement.appendChild(pElement);
        divElement.style.textAlign = "right";
        document.getElementById("chatChronology").appendChild(divElement);

        document.getElementById("peshoChatBox").value = "";
    }
}