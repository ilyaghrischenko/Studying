import { Modal } from "react-bootstrap";

import { MyForm } from "./MyForm";

import { Context } from "./Context";
import { useContext } from "react";

const MyModal = () => {
    const { show, onHide, actionType } = useContext(Context);

    return (
        <Modal show={show} onHide={onHide}>
            <Modal.Header closeButton>
                <div
                    style={{
                        display: 'flex',
                        justifyContent: 'center',
                        width: '100%'
                    }}
                >
                    <Modal.Title>{actionType.toUpperCase()}</Modal.Title>
                </div>
            </Modal.Header>

            <Modal.Body>
                <MyForm />
            </Modal.Body>
        </Modal>
    );
};

export { MyModal };