import React from 'react';
import { ListGroupItem, Image } from 'react-bootstrap';

const City = ({ name, description, gerb, citizensCount, square }) => {
    return (
        <ListGroupItem>
            <h2>{name}</h2>
            <p>{description}</p>
            <Image
                src={gerb}
                style={{
                    maxWidth: '300px',
                    maxHeight: '300px'
                }} />
            <p>Число граждан: {citizensCount}</p>
            <p>Квадрат: {square}</p>
        </ListGroupItem>
    );
};

export { City };