function solve() {

   let allBtn = Array.from(document.querySelectorAll(".profile button")).forEach(btn =>{
                                                         btn.addEventListener("click", btnClick);    
   });

   function btnClick() {
      let parent = this.parentElement;

      let lockRadioElement = parent.querySelectorAll('input')[0];

      if (!lockRadioElement.checked) {

         let hiddenFieldElement = parent.querySelector('[id$="HiddenFields"]');

         if (this.textContent === 'Show more') {
            hiddenFieldElement.style.display = 'block';
            this.textContent = 'Hide it';
         } else {
            hiddenFieldElement.style.display = 'none';
            this.textContent = 'Show more';
         }
      }
   }
}