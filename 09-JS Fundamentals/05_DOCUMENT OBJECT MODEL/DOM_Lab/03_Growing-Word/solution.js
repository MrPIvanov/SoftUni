function solve() {
   let button = document.getElementsByTagName("button")[0];
   let totalClicks = 0;

   button.addEventListener("click", buttonClick);


   function buttonClick() {

      let p = document.querySelector('#exercise p');

      if (totalClicks % 3 === 0) {
         p.style.color = "blue";
      } else if (totalClicks % 3 === 1) {
         p.style.color = "green";
      } else if (totalClicks % 3 === 2) {
         p.style.color = "red";
      }
      totalClicks++;
      p.style.fontSize = `${totalClicks * 2}px`;
   }
}