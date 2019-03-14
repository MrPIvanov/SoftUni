function deleteByEmail() {
    let $table = $('#customers');
    let $input = $('input[name=email]');

    let searchEmail = $input.val();

    let $elementToDelete = $table.find(`td:contains(${searchEmail})`);

    if ($elementToDelete.length > 0) {
        $elementToDelete.parent().remove();
        $('#result').text('Deleted.');
    } else {
        $('#result').text('Not found.');
    }
}