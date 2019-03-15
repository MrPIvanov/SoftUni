function addSticker(){
    let $title = $('input.title');
    let $content = $('input.content');

    if ($title.val() && $content.val()) {
        createSticker();
    }

    function createSticker(){
        let $list = $('#sticker-list');

        let $li = $('<li>');
        $li.addClass('note-content');

        let $a = $('<a>x</a>');
        $a.addClass('button');
        $a.on('click', function(e){
            $(e.target).parent().remove();
        });

        let $h2 = $(`<h2>${$title.val()}</h2>`);

        let $hr = $('hr');

        let $p = $(`<p>${$content.val()}</p>`);

        $li.append($a);
        $li.append($h2);
        $li.append($hr);
        $li.append($p);

        $list.append($li);

        $title.val('');
        $content.val('');
    }
}