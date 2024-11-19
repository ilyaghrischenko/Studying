import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

import React, { useState } from 'react';
import Container from 'react-bootstrap/Container';

import PhoneBook from './PhoneBook';
import ContactModel from './ContactModel';
import MyForm from './MyForm';

function App() {
    const [contacts, setContacts] = useState([]);
    const [searchQuery, setSearchQuery] = useState('');  // Новое состояние для строки поиска

    const addContact = (name, surname, phone, email) => {
        const newContact = new ContactModel(name, surname, phone, email);
        setContacts((prevContacts) => [...prevContacts, newContact]);
    };

    const updateContact = (updatedContact) => {
        setContacts((prevContacts) =>
            prevContacts.map((contact) =>
                contact.email === updatedContact.email ? updatedContact : contact
            )
        );
    };

    const deleteContact = (email) => {
        setContacts((prevContacts) =>
            prevContacts.filter(contact => contact.email !== email)
        );
    };

    const handleSearch = (query) => {
        setSearchQuery(query);
    };

    const filteredContacts = contacts.filter(contact =>
        contact.name.toLowerCase().includes(searchQuery.toLowerCase()) ||
        contact.surname.toLowerCase().includes(searchQuery.toLowerCase()) ||
        contact.phone.includes(searchQuery) ||
        contact.email.toLowerCase().includes(searchQuery.toLowerCase())
    );

    return (
        <div>
            <Container className='bg-light'>
                <input
                    type="text"
                    placeholder="Search contacts..."
                    value={searchQuery}
                    onChange={(e) => handleSearch(e.target.value)}
                    className="form-control mb-3"
                />
                <PhoneBook
                    className='phone-book'
                    contacts={filteredContacts}  // Отображаем отфильтрованные контакты
                    onEditContact={updateContact}
                    onDeleteContact={deleteContact}
                />
                <MyForm onAddContact={addContact} />
            </Container>
        </div>
    );
}

export default App;
