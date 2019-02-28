function getArticleGenerator(articles) {
    let arr = articles;
    let counter = 0;

    return  () => {
        if (arr.length > counter) {
            let currentArticle = document.createElement('article');
            currentArticle.textContent = arr[counter];
            counter++;

            let div = document.getElementById('content');
            div.appendChild(currentArticle);
        }
    };
}