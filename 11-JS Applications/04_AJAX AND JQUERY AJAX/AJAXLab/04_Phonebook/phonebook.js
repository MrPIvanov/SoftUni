let $loadBtn = $('#btnLoad');
let $createBtn = $('#btnCreate');

$loadBtn.on('click', loadPhonebook);
$createBtn.on('click', createRecord);

function loadPhonebook() {
    $('#phonebook').empty();

    let url = `https://phonebook-51284.firebaseio.com/.json`;

    $.ajax({
        method: 'GET',
        url: url,
        success: listPhonebook
    });

    function listPhonebook(data) {
        if (data) {
            Object.entries(data).forEach(x => {
                let objId = x[0];
                let dataObj = x[1];

                let $li = $('<li>');
                $li.text(`${dataObj.name}: ${dataObj.phone}`);
                $li.attr('id', objId);

                let $delBtn = $('<button>Delete</button>');
                $delBtn.on('click', delRecord);

                $li.append($delBtn);

                $('#phonebook').append($li);

                function delRecord(e) {
                    let currentId = $(e.target).parent().attr('id');

                    $.ajax({
                        method: 'DELETE',
                        url: `https://phonebook-51284.firebaseio.com/${currentId}.json`,
                    });

                    $(e.target).parent().remove();
                }
            });
        }
    }
}

function createRecord() {
    let name = $('#person').val();
    let phone = $('#phone').val();

    let objToSave = {
        name: name,
        phone: phone
    };

    $.ajax({
        method: 'POST',
        url: 'https://phonebook-51284.firebaseio.com/.json',
        data: JSON.stringify(objToSave),
        success: () => $('#btnLoad').click()
    });
}