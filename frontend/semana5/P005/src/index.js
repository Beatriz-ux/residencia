fetch("https://api.coinranking.com/v2/coins")
    .then(function (response) { return response.json(); })
    .then(function (data) {
    data.data.coins.slice(0, 5).map(function (coin, index) {
        insertCoin(coin, index);
    });
});
var apiNewsKey = "77f9e6e231514c529c7b630d33be5eca";
fetch("https://newsapi.org/v2/everything?q=cursos gratuitos superiores&apiKey=".concat(apiNewsKey))
    .then(function (response) { return response.json(); })
    .then(function (data) {
    data.articles.slice(0, 5).map(function (article) {
        insertNews(article);
    });
});
var apiPhotosKey = "SfOzAFE-EP-_QY9eTZo22HZ7IPIgAOVvqul0hxjplts";
fetch("https://api.unsplash.com/search/photos?page=1&query=education&client_id=".concat(apiPhotosKey))
    .then(function (response) { return response.json(); })
    .then(function (data) {
    data.results.slice(0, 3).map(function (photo) {
        insertPhoto(photo);
    });
});
function insertCoin(coin, index) {
    var coinList = document.getElementById("listaMoedas");
    var coinElement = document.createElement("a");
    coinElement.classList.add("coins");
    coinElement.innerHTML = "\n      <img src=\"".concat(coin.iconUrl, "\" alt=\"").concat(coin.name, "\" />\n            <span>").concat(index + 1, "\u00BA ").concat(coin.name, "</span>\n      ");
    coinList === null || coinList === void 0 ? void 0 : coinList.appendChild(coinElement);
}
function insertNews(article) {
    var listNews = document.getElementById("news");
    var news = document.createElement("div");
    news.classList.add("news-item");
    news.innerHTML = "\n    <b>".concat(article.title, "</b>\n            <ul>\n              <li><a href=\"").concat(article.url, "\" target=\"_blank\">Veja sobre</a></li>\n            </ul>\n    ");
    listNews === null || listNews === void 0 ? void 0 : listNews.appendChild(news);
}
function insertPhoto(photo) {
    var photosList = document.getElementById("listaImg");
    var element = document.createElement("div");
    element.classList.add("imagem");
    element.innerHTML = "<img src=\"".concat(photo.urls.regular, "\" alt=\"").concat(photo.alt_description, "\" />");
    photosList === null || photosList === void 0 ? void 0 : photosList.appendChild(element);
}
