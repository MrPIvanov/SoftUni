function solve() {
   let prices = {
      fundamentals: 170,
      advanced: 180,
      applications: 190,
      web: 490

   };

   let $btn = $('button');
   $btn.on('click', btnClick);

   let $body = $('.courseBody ul').last();

   let $price = $('.courseFoot p');

   function btnClick(){
      let $form = $('input:checked').last();

      let $selected = $('input[type = "checkbox"]:checked');

      let selectedCources = Array.from($('input[type = "checkbox"]:checked')).map(x => $(x).val().split('-')[1]);

      if (selectedCources.includes('advanced') && selectedCources.includes('fundamentals')) {
         prices.advanced = prices.advanced * 0.9;
      }

      if (selectedCources.includes('advanced') && selectedCources.includes('fundamentals') && selectedCources.includes('applications')) {
         prices.advanced = prices.advanced * 0.94;
         prices.fundamentals = prices.fundamentals * 0.94;
         prices.applications = prices.applications * 0.94;
      }

      if ($form.val() === 'online') {
         prices.advanced = prices.advanced * 0.94;
         prices.fundamentals = prices.fundamentals * 0.94;
         prices.applications = prices.applications * 0.94;
         prices.web = prices.web * 0.94;
      }
     

      for (const item of $selected) {
         let val = $($(item).parent().children()[1]).text().split(' ').slice(0, 2).join('-');

         let $li = $(`<li>${val}</li>`);
         
         $body.append($li);
      }

      if ($selected.length === 4) {
         let $li = $(`<li>HTML and CSS</li>`);  // MAYBE !!!!!!!!
         
         $body.append($li);
      }
      
      let totalPrice = 0;

      for (const cource of selectedCources) {
         totalPrice += prices[cource];
      }

      totalPrice = Math.floor(totalPrice);
      
      $price.text(`Cost: ${totalPrice}.00 BGN`);
   }
}

//solve();