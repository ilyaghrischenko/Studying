import '../styles/Header.css';

import React from 'react';
import { Container, ListGroup, ListGroupItem } from 'react-bootstrap';

import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';

import { Home } from './Home';
import { About } from './About';
import { Users } from './Users';

const Header = () => {
    return (
        <header>
            <Container>
                <Router>
                    <div>
                        <ListGroup className='list-links'>
                            <ListGroupItem>
                                <Link to="/">Home</Link>
                            </ListGroupItem>
                            <ListGroupItem>
                                <Link to="/about">About</Link>
                            </ListGroupItem>
                            <ListGroupItem>
                                <Link to="/users">Users</Link>
                            </ListGroupItem>
                        </ListGroup>

                        <Routes>
                            <Route exact path="/" component={Home} />
                            <Route path="/about" component={About} />
                            <Route path="/users" component={Users} />
                        </Routes>
                    </div>
                </Router>
            </Container>
        </header>
    );
};

export { Header };