class NewsFeed {
    constructor() {
        this.newsArray = [];
    }

    get count() {
        return this.newsArray.length;
    }

    addNews(newsItem) {
        this.newsArray.push(newsItem);
    }

    removeNews(index) {
        if (index >= 0 && index < this.newsArray.length) {
            this.newsArray.splice(index, 1);
        }
    }

    sortByDate() {
        this.newsArray.sort((a, b) => b.publishDate - a.publishDate);
    }

    searchByTag(tag) {
        return this.newsArray.filter(news => news.tags.includes(tag));
    }

    displayAllNews() {
        this.newsArray.forEach(news => news.print());
    }
}

const newsFeed = new NewsFeed();
newsFeed.addNews(new News("Перша новина", "Текст першої новини", ["#first"], "2024-10-15"));
newsFeed.addNews(new News("Друга новина", "Текст другої новини", ["#second"], "2024-10-12"));
newsFeed.addNews(new News("Третя новина", "Текст третьої новини", ["#third"], "2024-10-10"));

document.write(`<p>Кількість новин: ${newsFeed.count}</p>`);

newsFeed.displayAllNews();

document.write("<h2>Сортування новин за датою:</h2>");
newsFeed.sortByDate();
newsFeed.displayAllNews();

document.write("<h2>Пошук новин за тегом '#first':</h2>");
const foundNews = newsFeed.searchByTag("#first");
foundNews.forEach(news => news.print());