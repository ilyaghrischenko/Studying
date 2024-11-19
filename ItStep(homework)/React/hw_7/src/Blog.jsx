import React from 'react';
import { Container, CardText, ListGroup, ListGroupItem } from 'react-bootstrap';

const Blog = ({ name, text, date, tags }) => {
    return (
        <Container style={{
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center'
        }}>
            <h1>{name}</h1>
            <CardText>{text}</CardText>
            <CardText>{date}</CardText>
            <ListGroup style={{
                width: '15%',
            }}>
                {tags.map((item, index) => (
                    <ListGroupItem key={index}>
                        <CardText
                            style={{
                            textAlign: 'center'
                        }}>
                            #{item}
                        </CardText>
                    </ListGroupItem>
                ))}
            </ListGroup>
        </Container>
    );
};

export { Blog };