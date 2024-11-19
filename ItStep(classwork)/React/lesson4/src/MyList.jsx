import { Col, ListGroup, ListGroupItem } from 'react-bootstrap';
import MyListItem from './MyListItem';
import { TodoContext } from './Context';
import { useContext } from 'react';

const MyList = () => {
    const { todo } = useContext(TodoContext);

    if (todo.length === 0) {
        return (
            <Col xs={12} className='pt-3 pb-3'>
                <p>No tasks</p>
            </Col>
        );
    }

    return (
        <Col xs={12}>
            <ListGroup as='ul'>
                {
                    todo.map(item => <MyListItem
                            key={item.id}
                            elem={item}/>)
                }
            </ListGroup>
        </Col>
    );
}

export default MyList;