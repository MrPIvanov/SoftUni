function extractText() {
   let result = [];
   let items = $('#items li').toArray().forEach(element => {
      result.push(element.textContent);
   });

   $('#result').text(result.join(', '));
}