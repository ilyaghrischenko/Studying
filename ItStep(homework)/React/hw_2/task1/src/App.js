import React from 'react';
import FavoriteFilm from './FavoriteFilm';

function App() {
  return (
    <div>
      <FavoriteFilm
        name="Harry Potter"
        director="Chris Columbus"
        year={2001}
        studio="Warner Bros."
        posterUrl="img/harryPoter.jpg" />
        {/* Не пойму почему, но не загружает фото, хотя путь указан верно) */}
    </div>
  );
}

export default App;
