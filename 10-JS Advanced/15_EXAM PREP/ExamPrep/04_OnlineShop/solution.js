function onlineShop(selector) {
    let form = `<div id="header">Online Shop Inventory</div>
    <div class="block">
        <label class="field">Product details:</label>
        <br>
        <input placeholder="Enter product" class="custom-select">
        <input class="input1" id="price" type="number" min="1" max="999999" value="1"><label class="text">BGN</label>
        <input class="input1" id="quantity" type="number" min="1" value="1"><label class="text">Qty.</label>
        <button id="submit" class="button" disabled>Submit</button>
        <br><br>
        <label class="field">Inventory:</label>
        <br>
        <ul class="display">
        </ul>
        <br>
        <label class="field">Capacity:</label><input id="capacity" readonly>
        <label class="field">(maximum capacity is 150 items.)</label>
        <br>
        <label class="field">Price:</label><input id="sum" readonly>
        <label class="field">BGN</label>
    </div>`;
    $(selector).html(form);

    let totalPrice = 0;
    let totalQuantiy = 0;

    let $btn = $('#submit');
    let $productName = $('.custom-select');
    let $productPrice = $('#price');
    let $productQuantity = $('#quantity');
    let $inventory = $('.display');
    let $capacity = $('#capacity');
    let $sum = $('#sum');

    $productName.on('input', inputChange);
    $btn.on('click', addProduct);

    function inputChange() {
        if ($productName.val() === '') {
            $btn.attr('disabled', true);
        } else {
            $btn.attr('disabled', false);
        }
    }

    function addProduct() {
        let $li = $('<li>');
        $li.text(`Product: ${$productName.val()} Price: ${$productPrice.val()} Quantity: ${$productQuantity.val()}`)

        $inventory.append($li);

        totalPrice += +$productPrice.val();
        totalQuantiy += +$productQuantity.val();

        $productName.val('');
        $productPrice.val('1');
        $productQuantity.val('1');
        $btn.attr('disabled', true);
        $sum.val(totalPrice);

        if (totalQuantiy >= 150) {
            $capacity.addClass('fullCapacity');
            $capacity.val('full');
            $productName.attr('disabled', true);
            $productPrice.attr('disabled', true);
            $productQuantity.attr('disabled', true);
            $btn.attr('disabled', true);
        } else {
            $capacity.val(totalQuantiy);
        }
    }
}