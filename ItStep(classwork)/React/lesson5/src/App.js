import './style.scss';
import Counter from './Counter';
import Context from './Context';


function App() {
  return (
    <Context>
      <Counter/>
    </Context>
  );
}

export default App;
