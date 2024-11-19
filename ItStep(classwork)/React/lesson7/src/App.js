import {Header} from './components/Header';
import { Home } from './components/Home';
import { Books } from './components/Books';
import { Users } from './components/Users';
import { Cards } from './components/Cards';
import { NotFound } from './components/NotFound';

import { Routes, Route } from 'react-router-dom';
import {Container} from 'react-bootstrap';
import {createStore} from 'redux';
import { Provider } from 'react-redux';
import {demo} from './demo';

function App() {
  const reducer = (books = demo, action) => {
    switch (action.type) {
      case 'ADD_BOOK':
        return [...books, action.payload];
      case 'DELETE_BOOK':
        return books.filter((book) => book.id !== action.payload);
      case 'EDIT_BOOK':
        return books.map((book) =>
          book.id === action.payload.id ? action.payload : book
        );
      default:
        return [...books];
    }
  };

  const books = createStore(reducer);

  return ( 
    <Provider store={books}>
      <Header/>
      <Container className = "pt-3 pb-3">
          <Routes>
            <Route path ="/" element = {<Home/>}/>
            <Route path ="/books" element = {<Books/>}/>
            <Route path ="/users" element = {<Users/>}/>
            <Route path ="/cards" element = {<Cards/>}/>
            <Route path ="*" element = {<NotFound/>}/>
          </Routes>
      </Container>
    </Provider>
  );
};

export default App;
