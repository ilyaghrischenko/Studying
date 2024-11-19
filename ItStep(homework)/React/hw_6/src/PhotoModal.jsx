import {Modal} from 'react-bootstrap';
import React from 'react';

const PhotoModal = ({show, onHide, photo, desc}) => {
    return (
        <Modal show={show} onHide={onHide}>
            <Modal.Header closeButton>
                <Modal.Title>Photo</Modal.Title>
            </Modal.Header>

            <Modal.Body style={{
                display: 'flex',
                flexDirection: 'column',
                alignItems: 'center'
            }}>
                <img
                    src={photo}
                    alt="Photo"
                    style={{
                        maxWidth: '100%',
                        maxHeight: '100%'
                    }} />
                <p>{desc}</p>
            </Modal.Body>
        </Modal>
    );
};

export {PhotoModal};