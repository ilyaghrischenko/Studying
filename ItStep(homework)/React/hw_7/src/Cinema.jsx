import React from 'react';

import { Container, CardText, Image, ListGroup, ListGroupItem } from 'react-bootstrap';

const Cinema = ({ name, description, poster, sessions }) => {
    return (
        <Container style={{
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center'
        }}>
            <Image
                src={poster}
                alt="poster"
                style={{
                    width: '20%',
                    height: '20%'
                }} />
            <h1>{name}</h1>
            <CardText>{description}</CardText>

            <ListGroup style={{
                width: '30%'
            }}>
                {sessions.map((item, index) => (
                    <ListGroupItem key={index}>
                        <CardText>{item}</CardText>
                    </ListGroupItem>
                ))}
            </ListGroup>
        </Container>
    );
};

export { Cinema };