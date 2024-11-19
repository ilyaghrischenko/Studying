import {Container, Navbar, Nav} from 'react-bootstrap';
import {NavLink} from 'react-router-dom';

const Header = () => {
    return (
        <Navbar bg="dark" data-bs-theme="dark">
            <Container>
                <Navbar.Brand href="#home">
                    <h2>Бібліотека</h2>
                </Navbar.Brand>
                <Nav className="ms-auto">
                    <NavLink to="/" className="nav-link">Головна</NavLink>
                    <NavLink to="/books" className="nav-link">Книги</NavLink>
                    <NavLink to="/users" className="nav-link">Відвідувачі</NavLink>
                    <NavLink to="/cards" className="nav-link">Картки</NavLink>
                </Nav>
            </Container>
        </Navbar>
    )
}

export {Header}