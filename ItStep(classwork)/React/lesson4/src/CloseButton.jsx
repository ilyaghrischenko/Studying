import { Button } from 'react-bootstrap';
import { TodoContext } from './Context';
import { useContext } from 'react';

export default function CloseButton() {
    const { setMessage } = useContext(TodoContext);

    return (
        <Button 
            style={{ 
                position: 'absolute', 
                top: '10px',
                right: '10px',
                backgroundColor: 'transparent',
                border: 'none',
                padding: '0',
                cursor: 'pointer',
                color: 'red'
            }}
            className='closeBtn'
            aria-label="Close"
            onClick={() => {
                setMessage('');
            }}
        >
            <span aria-hidden="true">&times;</span>
        </Button>
    );
}
