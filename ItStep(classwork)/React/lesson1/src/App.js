import React from 'react';
import Li from './Li';
import './style.css';

function App() {
  const arr = ['Sofiya', 'Zlata', 'Maksim', 'Oleksandr', 'Illia'];

  return (
    <>
      <h1>Hello World!</h1>
      <ul className="test">
        {
          arr.map((item, index) => <Li key={index} name={item} />)
        }
      </ul>
    </>
  );
}

export default App;
