import React, { useState, useRef } from 'react';

import './Form.css';
import './RegistrationForm.css';

import { Form, Button, Container, CardText } from 'react-bootstrap';
import { MyModal } from './MyModal';

const RegistrationForm = () => {
    const loginForm = useRef();
    const emailForm = useRef();
    const sexForm = useRef();
    const ageForm = useRef();

    const [showModal, setShowModal] = useState(false);
    const [errorMessage, setErrorMessage] = useState('');
    
    const [resultText, setResultText] = useState('');

    const validateData = (login, email, sex, age) => {
        if (login === '' || email === '' || sex === '' || age === '') {
            setErrorMessage('Please fill all fields to register.');
            return false;
        } else if (login.length < 6 || login.length > 20) {
            setErrorMessage('Login must be between 6 and 20 characters.');
            return false;
        }

        return true;
    };

    const getFormData = () => {
        if (!loginForm.current.value || !emailForm.current.value || !sexForm.current.value || !ageForm.current.value) {
            return {
                login: '',
                email: '',
                sex: '',
                age: ''
            };
        }

        return {
            login: loginForm.current.value,
            email: emailForm.current.value,
            sex: sexForm.current.value,
            age: ageForm.current.value
        };
    };

    const handleSubmit = (e) => {
        e.preventDefault();

        const {login, email, sex, age} = getFormData();

        if (!validateData(login, email, sex, age)) {
            setShowModal(true);
            return;
        }
    };

    const updateResultText = () => {
        const {login, email, sex, age} = getFormData();

        setResultText(`Login: ${login}\nEmail: ${email}\nSex: ${sex}\nAge: ${age}`);
    };

    return (
        <Container>
            <Form className='form' onSubmit={handleSubmit}>
                <Form.Group>
                    <Form.Label>Login</Form.Label>
                    <Form.Control
                        type="text"
                        placeholder="Enter login"
                        ref={loginForm}
                        onChange={updateResultText} />
                </Form.Group>

                <Form.Group>
                    <Form.Label>Email</Form.Label>
                    <Form.Control
                        type="email"
                        placeholder="Enter email"
                        ref={emailForm}
                        onChange={updateResultText} />
                </Form.Group>

                <Form.Group>
                    <Form.Label>Sex</Form.Label>
                    <Form.Control
                        as="select"
                        ref={sexForm}
                        onChange={updateResultText}>
                        <option>Male</option>
                        <option>Female</option>
                    </Form.Control>
                </Form.Group>

                <Form.Group>
                    <Form.Label>Age</Form.Label>
                    <Form.Control
                        type="number"
                        placeholder="Enter age"
                        ref={ageForm}
                        onChange={updateResultText} />
                </Form.Group>

                <Button
                    variant="primary"
                    type="submit"
                    className='submit-btn'>
                    Submit
                </Button>
            </Form>

            <MyModal
                show={showModal}
                onHide={() => setShowModal(false)}
                errorMessage={errorMessage} />

            <CardText className='result-text'>
                {resultText}
            </CardText>
        </Container>
    );
};

export { RegistrationForm };
