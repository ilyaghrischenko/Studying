import { Form, Button } from "react-bootstrap";

import { Context } from "./Context";
import { useContext } from "react";

const MyForm = () => {
    const {
        formName,
        formAuthor,
        formGenre,
        formYear,
        formPagesCount,
        formHandler,
        actionType
    } = useContext(Context);

    return (
        <Form onSubmit={(e) => formHandler(e, actionType)}
            style={{
                display: 'flex',
                flexDirection: 'column',
                gap: '12px'
            }}>
                
            {actionType !== 'edit' ?
                <Form.Group>
                    <Form.Label>Name</Form.Label>
                    <Form.Control
                        required type="text"
                        placeholder="Enter name"
                        ref={formName} />
                </Form.Group>
                : null}

            <Form.Group>
                <Form.Label>Author</Form.Label>
                <Form.Control
                    required type="text"
                    placeholder="Enter author"
                    ref={formAuthor} />
            </Form.Group>
            <Form.Group>
                <Form.Label>Genre</Form.Label>
                <Form.Control
                    required
                    type="text"
                    placeholder="Enter genre"
                    ref={formGenre} />
            </Form.Group>
            <Form.Group>
                <Form.Label>Year</Form.Label>
                <Form.Control
                    required
                    type="text"
                    placeholder="Enter year"
                    ref={formYear} />
            </Form.Group>
            <Form.Group>
                <Form.Label>Pages Count</Form.Label>
                <Form.Control
                    required
                    type="number"
                    placeholder="Enter pages count"
                    ref={formPagesCount} />
            </Form.Group>

            <Button
                type="submit"
                variant="primary"
            >
                Submit
            </Button>
        </Form>
    );
};

export { MyForm };