import { Button, Container, Form } from "react-bootstrap";
import "./Form.css";

import React, { useState, useRef } from "react";
import { ResultModal } from "./ResultModal";

const TextForm = () => {
    const [showModal, setShowModal] = useState(false);
    const [result, setResult] = useState('');

    const textForm = useRef();

    const handleSubmit = (e) => {
        e.preventDefault();

        const text = textForm.current.value;

        const sentencesCount = text.split(' ').length;
        [text].forEach((item) => {
            const vowelsCount = item.match(/[аеєиіїоуюя]/gi)?.length || 0;
            const consonantsCount = item.match(/[бвгґдєжзйклмнпрстфхцчшщ]/gi)?.length || 0;
        
            setResult(
                `Sentences count: ${sentencesCount}\n` +
                `Vowels count: ${vowelsCount}\n` +
                `Consonants count: ${consonantsCount}`
            );
        });

        setShowModal(true);
    };

    return (
        <Container>
            <Form
                className="form"
                onSubmit={handleSubmit}>
                <Form.Group>
                    <Form.Label>Text</Form.Label>
                    <Form.Control
                        type="text"
                        placeholder="Enter text"
                        ref={textForm} />
                </Form.Group>

                <Button
                    variant="primary"
                    type="submit"
                    className='submit-btn'>
                    Submit
                </Button>
            </Form>

            <ResultModal
                show={showModal}
                onHide={() => setShowModal(false)}
                result={result} />
        </Container>
    );
};

export { TextForm };