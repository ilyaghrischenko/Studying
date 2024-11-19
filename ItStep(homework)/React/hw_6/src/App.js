import React from 'react';
import './App.css';

import 'bootstrap/dist/css/bootstrap.min.css';
import {Container} from 'react-bootstrap';

import {RegistrationForm} from './RegistrationForm';
import { TextForm } from './TextForm';
import { PhotoForm } from './PhotoForm';

function App() {
  return (
    <Container className='container'>
      <RegistrationForm />
      {/* <PhotoForm /> Task 2 */}
      {/* <TextForm /> Task 4 */}
    </Container>
  );
}

export default App;
