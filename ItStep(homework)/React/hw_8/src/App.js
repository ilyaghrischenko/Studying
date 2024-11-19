import 'bootstrap/dist/css/bootstrap.min.css';
import { Container } from 'react-bootstrap';

import { Library } from './Library';

import { ContextProvider } from './Context';

function App() {
  return (
    <ContextProvider>
      <Container style={{ marginTop: '20px' }}>
        <Library />
      </Container>
    </ContextProvider>
  );
}

export default App;
