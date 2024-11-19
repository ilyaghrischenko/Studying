import ListGroup from 'react-bootstrap/ListGroup';
import Contact from "./Contact";

export default function PhoneBook({ contacts, onEditContact, onDeleteContact }) {
    return (
        <div className="phone-book">
            <ListGroup>
                {contacts.map(contact => (
                    <ListGroup.Item key={contact.email}>
                        <Contact 
                            contact={contact}
                            onEdit={() => onEditContact(contact)}
                            onDelete={() => onDeleteContact(contact.email)}
                        />
                    </ListGroup.Item>
                ))}
            </ListGroup>
        </div>
    );
}
