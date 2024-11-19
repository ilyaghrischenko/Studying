import './Form.css';
import React, { useState, useRef } from 'react';

import { Container, Form, Button } from 'react-bootstrap';
import { PhotoModal } from './PhotoModal';

const PhotoForm = () => {
    const loginForm = useRef();
    const emailForm = useRef();
    const photoForm = useRef();
    const descriptionForm = useRef();

    const [showModal, setShowModal] = useState(false);
    const [photo, setPhoto] = useState('');
    const [description, setDescription] = useState('');

    const handleSubmit = (e) => {
        e.preventDefault();

        const login = loginForm.current.value;
        const email = emailForm.current.value;
        const photo = photoForm.current.files[0];
        const description = descriptionForm.current.value;

        setPhoto(URL.createObjectURL(photo));
        setDescription(description);

        setShowModal(true);
    };

    return (
        <Container>
            <Form
                className='form'
                onSubmit={handleSubmit}
            >
                <Form.Group>
                    <Form.Label>Login</Form.Label>
                    <Form.Control
                        type="text"
                        placeholder="Enter login"
                        ref={loginForm} />
                </Form.Group>

                <Form.Group>
                    <Form.Label>Email</Form.Label>
                    <Form.Control
                        type="email"
                        placeholder="Enter email"
                        ref={emailForm} />
                </Form.Group>

                <Form.Group>
                    <Form.Label>Photo</Form.Label>
                    <Form.Control
                        type="file"
                        ref={photoForm} />
                </Form.Group>

                <Form.Group>
                    <Form.Label>Description</Form.Label>
                    <Form.Control
                        as="textarea"
                        rows="3"
                        placeholder="Enter description"
                        ref={descriptionForm} />
                </Form.Group>

                <Button
                    variant="primary"
                    type="submit"
                    className='submit-btn'
                >
                    Submit
                </Button>
            </Form>

            <PhotoModal
                show={showModal}
                onHide={() => setShowModal(false)}
                photo={photo}
                desc={description} />
        </Container>
    );
};

export { PhotoForm };