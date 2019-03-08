function initializeTable() {
    addCountry('Bulgaria', 'Sofia');
    addCountry('Germany', 'Berlin');
    addCountry('Russia', 'Moscow');

    $('#createLink').on('click', addNewCountry);
    
    function addNewCountry(){
        addCountry($('#newCountryText').val(), $('#newCapitalText').val());
    }
    function addCountry(country, capital){
        let div = $('#countriesTable');
        let tr = $('<tr>');

        let tdCountry = $('<td>');
        tdCountry.text(country);

        let tdCapital = $('<td>');
        tdCapital.text(capital);

        let tdActions = $('<td>');
        let up = $('<a>');
        up.text('[Up]');
        up.on('click', upFunction);
        let down = $('<a>');
        down.text('[Down]');
        down.on('click', downFunction);
        let deleteRow = $('<a>');
        deleteRow.text('[Delete]');
        deleteRow.on('click', deleteRowFunction);


        tdActions.append(up);
        tdActions.append(down);
        tdActions.append(deleteRow);

        tr.append(tdCountry);
        tr.append(tdCapital);
        tr.append(tdActions);
        div.append(tr);

        fixBtn();
    }

    function upFunction(){
        let currentRow = $(this).parent().parent();
        
        currentRow.insertBefore(currentRow.prev());
        fixBtn();
    }
    function downFunction(){
        let currentRow = $(this).parent().parent();
        
        currentRow.insertAfter(currentRow.next());
        fixBtn();
    }
    function deleteRowFunction(){
        let currentRow = $(this).parent().parent();

        currentRow.remove();
        fixBtn();
    }

    function fixBtn(){
        $('#countriesTable tr :nth-child(3) a').show();

        $('#countriesTable tr:nth-child(3) td:nth-child(3) a:nth-child(1)').hide();
        $('#countriesTable tr:last-child td:nth-child(3) a:nth-child(2)').hide();
    }
}