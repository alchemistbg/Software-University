function acceptance() {
	let company = $('#fields td input').eq(0).val();
	let product = $('#fields td input').eq(1).val();
	let quantity = $('#fields td input').eq(2).val();
	let scrape = $('#fields td input').eq(3).val();
	if(company || product|| quantity || scrape){
	    if (!/[.]/.test(company) && !/[.]/.test(product) &&
            !Number.isInteger(quantity) && !Number.isInteger(scrape)){
	        let pieces = quantity - scrape;
	        let outOfStockButton = $('<button>').prop('type', 'button').text('Out of stock');
	        let textToAdd = `[${company}] ${product} - ${pieces} pieces`;
            let pToAdd = $('<p>').text(textToAdd);
            let div = $('<div>').append(pToAdd).append(outOfStockButton);
            if (pieces > 0) {
                $('#warehouse').append(div);
            }

	        outOfStockButton.on('click', (evt) => {

                //evt.preventDefault();
                evt.target.parentNode.remove();
            });
        }
    }

    $('#fields td input').eq(0).val('');
    $('#fields td input').eq(1).val('');
    $('#fields td input').eq(2).val('');
    $('#fields td input').eq(3).val('');
}