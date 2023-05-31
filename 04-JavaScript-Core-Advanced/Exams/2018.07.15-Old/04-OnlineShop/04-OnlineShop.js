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

    let totalCapacity = 0;
    let totalPrice = 0;

    let $productName = $('.custom-select');
    $productName.on('input', () => {
        if ($productName.length > 0) {
            $('#submit').prop('disabled', false);
        } else {
            $('#submit').prop('disabled', true);
        }
    });

    $('#submit').on('click', () => {

        let $productPrice = +$('#price').val();
        let $productQty = +$('#quantity').val();

        let $item = $('<li>').text(`Product: ${$productName.val()} Price: ${$productPrice} Quantity: ${$productQty}`).appendTo($('.display'));

        totalPrice += $productPrice;
        $('#sum').val(totalPrice);

        totalCapacity += $productQty;
        if (totalCapacity >= 150){
            $('#shelfCapacity').val('full').addClass('fullCapacity');
            $('.custom-select').prop('disabled', true);
            $('#price').prop('disabled', true);
            $('#quantity').prop('disabled', true);
            $('#submit').prop('disabled', true);
        }else{
            $('#shelfCapacity').val(totalCapacity);
        }

        $('.custom-select').val('');
        $('#price').val('1');
        $('#quantity').val('1');
        $('#submit').prop('disabled', true);
    });
}
