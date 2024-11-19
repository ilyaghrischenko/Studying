import { Col, Form, FormControl, FormGroup } from 'react-bootstrap';
import { TodoContext } from './Context';
import { useContext } from 'react';

const MyForm = () => {
    const { handlerAddTodo } = useContext(TodoContext);

    return (
        <Col xs={12}>
            <Form onSubmit={handlerAddTodo}>
                <FormGroup className='mt-3 mb-3'>
                    <FormControl
                        type='text'
                        placeholder='Enter your task...'
                        name='mytodo'/>

                </FormGroup>
            </Form>
        </Col>
    );
};

export default MyForm;