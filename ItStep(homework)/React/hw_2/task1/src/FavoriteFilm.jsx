export default function FavoriteFilm({name, director, year, studio, posterUrl}) {
    return (
      <div className="favorite-film">
        <h1>{name}</h1>
        <h2>{director}</h2>
        <p>{year}</p>
        <p>{studio}</p>
        <img src={posterUrl} alt="poster" />
      </div>  
    );
}