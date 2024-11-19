class News {
    constructor(title, text, tags, publishDate) {
        this.title = title;
        this.text = text;
        this.tags = tags;
        this.publishDate = new Date(publishDate);
    }

    print() {
        const currentDate = new Date();
        const timeDiff = Math.abs(currentDate - this.publishDate);
        const diffDays = Math.ceil(timeDiff / (1000 * 3600 * 24));

        let dateString;
        if (diffDays < 1) {
            dateString = "сьогодні";
        } else if (diffDays < 7) {
            dateString = `${diffDays} днів тому`;
        } else {
            dateString = this.publishDate.toLocaleDateString('uk-UA'); 
        }

        document.write(`<h3>${this.title}</h3>`);
        document.write(`<p>Дата: ${dateString}</p>`);
        document.write(`<p>${this.text}</p>`);
        document.write(`<p>Теги: ${this.tags.join(', ')}</p>`);
        document.write('<hr>');
    }
}

const news = new News("Що таке Lorem Ipsum?", "Lorem Ipsum is simply dummy text...", ["#lorem", "#text"], "2023-10-15");
news.print();
