function addItem() {
    let text = $('#newItemText').val();

    let $li = $('<li>');
    $li.text(text);
    $('#items').append($li);

    $('#newItemText').val('');
}