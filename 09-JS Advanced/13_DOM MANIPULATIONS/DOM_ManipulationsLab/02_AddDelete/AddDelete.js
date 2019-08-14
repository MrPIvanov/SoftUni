function addItem() {
    let $items = $('#items');
    let $input = $('#newText');

    let $li = $('<li>');
    $li.text($input.val());
    $input.val('');

    let $deleteBtn = $('<a href="#">[Delete]</a>');
    $deleteBtn.on('click', deleteItem);
    $li.append($deleteBtn);
    $items.append($li);

    function deleteItem(e) {
        $(e.target).parent().remove();
    }
}