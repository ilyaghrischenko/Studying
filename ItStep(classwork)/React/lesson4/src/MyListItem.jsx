import { FaTrash } from 'react-icons/fa';
import { ListGroupItem } from 'react-bootstrap';
import { TodoContext } from './Context';
import { useContext } from 'react';

const MyListItem = ({elem}) => {
    const {
        handlerDeleteTodoItem,
        handlerSelectTodoItem
    } = useContext(TodoContext);

    return (
        <ListGroupItem onClick={() => handlerSelectTodoItem(elem.id)}
            as='li'
            className='p-2 d-flex justify-content-between'
            variant= {elem.status && 'success'}>
            
            <span >{elem.title}</span>
            <span><FaTrash onClick={() => handlerDeleteTodoItem(elem.id)}/></span>
        </ListGroupItem>
    );
}

export default MyListItem;