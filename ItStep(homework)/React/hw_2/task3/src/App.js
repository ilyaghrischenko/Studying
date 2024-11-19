import logo from './logo.svg';
import './App.css';
import CurrentTime from './CurrentTime';

function App() {
  return (
    <div className="App">
      <CurrentTime dateTime={new Date().toLocaleString()} />
    </div>
  );
}

export default App;
