import './App.css';
import PhotoGallery from "./PhotoGallery";
import { useState } from "react";

import krImg from "./img/kr.jpg";
import kyivImg from "./img/kyiv.jpg";
import warsawImg from "./img/warsaw.jpg";

function App() {
  const [filter, setFilter] = useState("");

  const photos = [
    { path: krImg, description: "Kremenchuk city" },
    { path: kyivImg, description: "Kyiv city" },
    { path: warsawImg, description: "Warsaw city" },
  ];

  const filteredPhotos = photos.filter(photo =>
    photo.description.toLowerCase().includes(filter.toLowerCase())
  );

  return (
    <div className="App">
      <input
        type="text"
        placeholder="Filter by description"
        value={filter}
        onChange={(e) => setFilter(e.target.value)}
      />
      <PhotoGallery photos={filteredPhotos} />
    </div>
  );
}

export default App;
