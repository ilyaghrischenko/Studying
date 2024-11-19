import {Modal} from 'react-bootstrap';

const MyModal = ({show, onHide, errorMessage}) => {
    return (
        <Modal show={show} onHide={onHide}>
            <Modal.Header closeButton>
                <Modal.Title>Error</Modal.Title>
            </Modal.Header>

            <Modal.Body>
                <p>{errorMessage}</p>
            </Modal.Body>
        </Modal>
    );
};

export {MyModal};