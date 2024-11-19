class BookModel {
    constructor(name, author, genre, year, pagesCount) {
        this.id = Date.now();
        this.name = name;
        this.author = author;
        this.genre = genre;
        this.year = year;
        this.pagesCount = pagesCount;
    }
};

export default BookModel;