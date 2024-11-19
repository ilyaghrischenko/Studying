import React from 'react';
import { Container, Row } from 'react-bootstrap';
import MyForm from './MyForm';
import MyList from './MyList';
import Context from './Context';
import DangerMessage from './DangerMessage';

function App() {
  return (
    <div className='App'>
      <Context>
        <Container>
          <Row>
            <MyForm />
            <DangerMessage />
            <MyList />
          </Row>
        </Container>
      </Context>
    </div>
  );
}

export default App;
