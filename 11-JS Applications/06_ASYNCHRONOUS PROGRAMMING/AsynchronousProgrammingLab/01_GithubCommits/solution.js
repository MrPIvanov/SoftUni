function loadCommits() {
    const baseUrl = 'https://api.github.com/repos/';
    let userName = $('#username').val();
    let repo = $('#repo').val();

    let $commits = $('#commits');

    tryLoad();

    async function tryLoad() {
        try {
            let commitsResult = await $.ajax({
                method: 'GET',
                url: baseUrl + userName + '/' + repo + '/' + 'commits'
            });

            for (let commit of commitsResult) {
                let $li = $(`<li>${commit.commit.author.name}: ${commit.commit.message}</li>`)
                $commits.append($li);
            }
            
        } catch (error) {
            let $li = $(`<li>Error: ${error.status} (${error.statusText})</li>`);
            $commits.append($li);
        }
    }
}