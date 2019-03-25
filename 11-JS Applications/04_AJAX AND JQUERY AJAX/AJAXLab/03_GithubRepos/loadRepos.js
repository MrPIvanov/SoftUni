function loadRepos() {
    let $username = $('#username').val();

    let url = `https://api.github.com/users/${$username}/repos`;

    $.ajax({
        method: 'GET',
        url: url,
        success: onLoadReposSuccess
    });

    function onLoadReposSuccess(data) {
        $('#repos').empty();
        for (const obj of data) {
            let fullName = obj.full_name;
            let htmlUrl = obj.html_url;

            let $li = $('<li>');
            let $a = $(`<a>`);
            $a.attr('href', htmlUrl);
            $a.text(fullName);
            $li.append($a);

            $('#repos').append($li);
        }
    }
}