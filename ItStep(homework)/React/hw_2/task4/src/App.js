import logo from './logo.svg';
import './App.css';
import Pet from './Pet';

function App() {
  const pet = {
    name: "Pushok",
    age: 12,
    breed: "cat"
  };

  return (
    <div className="App">
      <Pet petInfo={pet} />
    </div>
  );
}

export default App;
