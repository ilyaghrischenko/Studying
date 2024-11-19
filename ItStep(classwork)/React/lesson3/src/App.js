import {useState} from 'react';
import './style.css';
import Div from './Div';

function App() {
  const [isVisible, setVisible] = useState(false);

  const clickHandler = () => setVisible(!isVisible);
  console.log(isVisible);

  return (
    <div className='App'>
      <button onClick={clickHandler}>Click me</button>
      <Div isVisible = {isVisible}/>
    </div>
  );
}

export default App;
