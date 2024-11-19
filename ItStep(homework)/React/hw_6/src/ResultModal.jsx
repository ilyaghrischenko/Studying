import {Modal} from 'react-bootstrap';

const ResultModal = ({show, onHide, result}) => {
    return (
        <Modal show={show} onHide={onHide}>
            <Modal.Header closeButton>
                <Modal.Title>Result</Modal.Title>
            </Modal.Header>

            <Modal.Body>
                <p>{result}</p>
            </Modal.Body>
        </Modal>
    );
};

export {ResultModal};