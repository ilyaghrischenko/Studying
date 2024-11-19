import './FavoriteBook.css';

export default function FavoriteBook() {
    const bookName = "The Great Gatsby";
    const author = "F. Scott Fitzgerald";
    const genre = "Fiction";
    const pagesCount = 1000;
    const comments = [
        "I loved it!",
        "It was good",
        "I'm reading it now, fantastic!"
    ]
    
    return (
        <div className="favorite-book">
            <h1>{bookName}</h1>
            <h2>{author}</h2>
            <p>{genre}</p>
            <p>{pagesCount} pages</p>
            <ul>
                {comments.map((comment, index) => (
                    <li key={index}>{comment}</li>
                ))}
            </ul>
        </div>
    );
}