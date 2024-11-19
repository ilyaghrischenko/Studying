import {useState} from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';

export default function MyForm({ onAddContact, initialValues = {} }) {
    const [name, setName] = useState(initialValues.name || '');
    const [surname, setSurname] = useState(initialValues.surname || '');
    const [phone, setPhone] = useState(initialValues.phone || '');
    const [email, setEmail] = useState(initialValues.email || '');

    const handleSubmit = (event) => {
        event.preventDefault();
        if (name && surname && phone && email) {
            onAddContact(name, surname, phone, email);
            setName('');
            setSurname('');
            setPhone('');
            setEmail('');
        }
    };

    return (
        <Form onSubmit={handleSubmit}>
            <Form.Group controlId="formName">
                <Form.Label>Name</Form.Label>
                <Form.Control
                    type="text"
                    placeholder="Enter name"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                />
            </Form.Group>

            <Form.Group controlId="formSurname">
                <Form.Label>Surname</Form.Label>
                <Form.Control
                    type="text"
                    placeholder="Enter surname"
                    value={surname}
                    onChange={(e) => setSurname(e.target.value)}
                />
            </Form.Group>

            <Form.Group controlId="formPhone">
                <Form.Label>Phone</Form.Label>
                <Form.Control
                    type="text"
                    placeholder="Enter phone"
                    value={phone}
                    onChange={(e) => setPhone(e.target.value)}
                />
            </Form.Group>

            <Form.Group controlId="formEmail">
                <Form.Label>Email</Form.Label>
                <Form.Control
                    type="email"
                    placeholder="Enter email"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                    disabled={initialValues.email ? true : false}
                />
            </Form.Group>

            <Button variant="primary" type="submit">
                Submit
            </Button>
        </Form>
    );
}
