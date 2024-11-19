import { Col, Stack, Button } from 'react-bootstrap';
import { FaPlusSquare } from "react-icons/fa";
import { FaTrash } from "react-icons/fa";
import { FaEdit } from "react-icons/fa";

import { useState } from 'react';
import { MyModal } from './MyModal';

const TableTools = () => {
    const [show, setShow] = useState(false);

    const handlerOpen = () => {
        setShow(true);
    };

    const handlerClose = () => {
        setShow(false);
    };

    return (
        <>
            <Col xs={12} className="mt-3 mb-3">
                <Stack gap={2} direction='horizontal' className='justify-content-end'>
                    <Button
                        variant="success"
                        onClick={handlerOpen}
                    >
                        <FaPlusSquare />
                    </Button>

                    <Button
                        variant="primary"
                        onClick={handlerOpen}
                    >
                        <FaEdit />
                    </Button>

                    <Button
                        variant="danger"
                    >
                        <FaTrash />
                    </Button>

                </Stack>
            </Col>

            <MyModal show={show} handlerClose={handlerClose} />
        </>
    )
};

export { TableTools };