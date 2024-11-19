import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import { useState, useRef } from 'react';

import {Form} from 'react-bootstrap';
import { useDispatch } from 'react-redux';

const MyModal = ({ show, handlerClose }) => {
    const formGroupTitle = useRef();
    const formGroupAuthor = useRef();
    const formGroupYear = useRef();
    const formGroupPublishing = useRef();
    const formGroupPages = useRef();
    const formGroupCopies = useRef();
    
    const dispatch = useDispatch();

    const handleBook = () => {
        const obj = {
            id: Date.now(),
            title: formGroupTitle.current.value, 
            author: formGroupAuthor.current.value,
            year: formGroupYear.current.value,
            publishing: formGroupPublishing.current.value,
            pages: formGroupPages.current.value,
            count: formGroupCopies.current.value,
            isSelect: false
        };

        dispatch({
            type: 'ADD_BOOK',
            payload: obj
        });

        handlerClose();
    };

    return (
        <Modal show={show} onHide={handlerClose}>
            <Modal.Header closeButton>
                <Modal.Title>Додати нову книжку</Modal.Title>
            </Modal.Header>

            <Modal.Body>
                <Form>
                    <Form.Group className="mb-3" controlId="formGroupTitle">
                        <Form.Label>Назва</Form.Label>
                        <Form.Control
                            type="text"
                            ref = {formGroupTitle} />
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formGroupAuthor">
                        <Form.Label>Ім'я автора</Form.Label>
                        <Form.Control
                            type="text"
                            ref = {formGroupAuthor} />
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formGroupYear">
                        <Form.Label>Рік видавництва</Form.Label>
                        <Form.Control
                            type="number"
                            ref = {formGroupYear} />
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formGroupPublishing">
                        <Form.Label>Назва видавництва</Form.Label>
                        <Form.Control
                            type="text"
                            ref = {formGroupPublishing} />
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formGroupPages">
                        <Form.Label>К-сть сторінок</Form.Label>
                        <Form.Control
                            type="number"
                            ref = {formGroupPages} />
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formGroupCopies">
                        <Form.Label>К-ть копій</Form.Label>
                        <Form.Control
                            type="number"
                            ref = {formGroupCopies} />
                    </Form.Group>
                </Form>
            </Modal.Body>

            <Modal.Footer>
                <Button variant="primary" onClick={handleBook}>
                    Зберегти
                </Button>
            </Modal.Footer>
        </Modal>
    );
};

export { MyModal };