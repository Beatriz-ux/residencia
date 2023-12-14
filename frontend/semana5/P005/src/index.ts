interface IResult {
  status: string;
  data: IData;
}

interface IData {
  stats: object;
  coins: ICoin[];
}

interface ICoin {
  uuid: string;
  symbol: string;
  name: string;
  color: string;
  iconUrl: string;
  marketCap: string;
  price: string;
  listedAt: number;
  tier: number;
  change: string;
  rank: number;
  sparkline: string[];
  lowVolume: boolean;
  coinrankingUrl: string;
  object: object;
  btcPrice: string;
}

interface INews {
  status: string;
  totalResults: number;
  articles: IArticle[];
}

interface IArticle {
  source: ISource;
  author: string;
  title: string;
  description: string;
  url: string;
  urlToImage: string;
  publishedAt: string;
  content: string;
}

type ISource = {
  id: string;
  name: string;
};

interface IPhotos {
  total: number;
  total_pages: number;
  results: IPhoto[];
}

interface IPhoto {
  alt_description: string;
  urls: {
    full: string;
    regular: string;
  };
}

fetch(`https://api.coinranking.com/v2/coins`)
  .then((response) => response.json())
  .then((data: IResult) => {
    data.data.coins.slice(0, 5).map((coin: ICoin, index) => {
      insertCoin(coin, index);
    });
  });

const apiNewsKey = "77f9e6e231514c529c7b630d33be5eca";
fetch(
  `https://newsapi.org/v2/everything?q=cursos gratuitos superiores&apiKey=${apiNewsKey}`
)
  .then((response) => response.json())
  .then((data: INews) => {
    data.articles.slice(0, 5).map((article: IArticle) => {
      insertNews(article);
    });
  });

const apiPhotosKey = "SfOzAFE-EP-_QY9eTZo22HZ7IPIgAOVvqul0hxjplts";

fetch(
  `https://api.unsplash.com/search/photos?page=1&query=education&client_id=${apiPhotosKey}`
)
  .then((response) => response.json())
  .then((data: IPhotos) => {
    data.results.slice(0, 3).map((photo) => {
      insertPhoto(photo);
    });
  });

function insertCoin(coin: ICoin, index: number) {
  const coinList = document.getElementById("listaMoedas");
  const coinElement = document.createElement("a");
  coinElement.classList.add("coins");
  coinElement.innerHTML = `
      <img src="${coin.iconUrl}" alt="${coin.name}" />
            <span>${index + 1}º ${coin.name}</span>
      `;
  coinList?.appendChild(coinElement);
}

function insertNews(article: IArticle) {
  const listNews = document.getElementById("news");
  const news = document.createElement("div");
  news.classList.add("news-item");
  news.innerHTML = `
    <b>${article.title}</b>
            <ul>
              <li><a href="${article.url}" target="_blank">Veja sobre</a></li>
            </ul>
    `;
  listNews?.appendChild(news);
}

function insertPhoto(photo: IPhoto) {
  const photosList = document.getElementById("listaImg");
  const element = document.createElement("div");
  element.classList.add("imagem");
  element.innerHTML = `<img src="${photo.urls.regular}" alt="${photo.alt_description}" />`;

  photosList?.appendChild(element);
}
