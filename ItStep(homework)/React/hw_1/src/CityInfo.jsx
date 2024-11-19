import React from 'react';
import './CityInfo.css';

const CityInfo = () => {
  const city = "Kyiv";
  const country = "Ukraine";
  const foundedYear = 482;
  const landmarks = [
    {
      name: "St. Sophia Cathedral",
      image: "./img/sophia_cathedral.jpg"
    },
    {
      name: "Kyiv Pechersk Lavra",
      image: "https://example.com/pechersk-lavra.jpg"
    },
    {
      name: "Independence Square",
      image: "https://example.com/independence-square.jpg"
    }
  ];

  return (
    <div className="city-info">
      <h1>{city}</h1>
      <h2>{country}</h2>
      <p>Founded in {foundedYear}</p>
      <h3>Landmarks:</h3>
      <div className="landmark-container">
        {landmarks.map((landmark, index) => (
          <div key={index} className="landmark">
            <img src={landmark.image} alt={landmark.name} />
            <h4>{landmark.name}</h4>
          </div>
        ))}
      </div>
    </div>
  );
};

export default CityInfo;
