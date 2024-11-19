import React, { useState } from 'react';
import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import MyForm from './MyForm';

export default function Contact({ contact, onEdit, onDelete }) {
    const [showModal, setShowModal] = useState(false);

    const handleEdit = () => setShowModal(true);
    const handleClose = () => setShowModal(false);

    return (
        <div>
            <p>PIB: {contact.name} {contact.surname}</p>
            <p>Phone: {contact.phone}</p>
            <p>Email: {contact.email}</p>
            <Button variant="warning" onClick={handleEdit}>Edit</Button>
            <Button variant="danger" onClick={onDelete}>Delete</Button>

            <Modal show={showModal} onHide={handleClose}>
                <Modal.Header closeButton>
                    <Modal.Title>Edit Contact</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <MyForm
                        initialValues={contact}
                        onAddContact={(name, surname, phone, email) => {
                            onEdit({ ...contact, name, surname, phone, email });
                            handleClose();
                        }}
                    />
                </Modal.Body>
            </Modal>
        </div>
    );
}
