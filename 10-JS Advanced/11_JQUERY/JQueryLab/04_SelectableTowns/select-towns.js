function attachEvents() {
	$('#items li').on('click', townClick);

	function townClick() {
		let currentTown = $(this);
		if (currentTown.attr("data-selected") === 'true') {
			currentTown.attr('data-selected', '');
			currentTown.css("background", '');
		} else {
			currentTown.attr('data-selected', 'true');
			currentTown.css("background", '#DDD');
		}
	}

	$('#showTownsButton').on('click', showTowns);

	function showTowns(){
		let result = [];
		$('li[data-selected]').each((i, element) => {
			result.push(element.textContent);
		});

		$('#selectedTowns').text(result.join(', '));
	}
}