import React from 'react';

import { ListGroup, Container } from 'react-bootstrap';

import { City } from './City';

const Country = ({ name, cities }) => {
    console.dir(name);
    console.dir(cities);
    return (
        <Container>
            <h1 style={{
                textAlign: 'center'
            }}>
                {name}
            </h1>
            <ListGroup style={{
                display: 'flex',
                flexDirection: 'row',
                justifyContent: 'space-around',
                alignItems: 'center',
                paddingTop: '40px',
                border: '1px solid black',
            }}>
                {cities.map((item, index) => (
                    <City {...item} key={index} />
                ))}
            </ListGroup>
        </Container>
    );
};

export { Country };