function search() {
   $(`li`).css('font-weight', 'normal'); 

   let searchValue = $('#searchText').val();

   $(`li:contains(${searchValue})`).css('font-weight', 'bold');  

   let counter = $(`li:contains(${searchValue})`).length;
   $('#result').text(`${counter} matches found`);
}