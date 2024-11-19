import React, { createContext, useState, useRef } from "react";
import BookModel from "./BookModel";

const Context = createContext();

const ContextProvider = ({children}) => {
    const [show, setShow] = useState(false);
    const [actionType, setActionType] = useState('');
    const [books, setBooks] = useState(
        [
            new BookModel('Harry Potter and the Philosopher\'s Stone', 'J.K. Rowling', 'Fantasy', 1997, 1120),
            new BookModel('Harry Potter and the Chamber of Secrets', 'J.K. Rowling', 'Fantasy', 1997, 1088),
            new BookModel('Harry Potter and the Prisoner of Azkaban', 'J.K. Rowling', 'Fantasy', 1997, 1066),
            new BookModel('Harry Potter and the Goblet of Fire', 'J.K. Rowling', 'Fantasy', 1997, 1040),
            new BookModel('Harry Potter and the Order of the Phoenix', 'J.K. Rowling', 'Fantasy', 1997, 1024),
            new BookModel('Harry Potter and the Half-Blood Prince', 'J.K. Rowling', 'Fantasy', 1998, 984),
            new BookModel('Harry Potter and the Deathly Hallows', 'J.K. Rowling', 'Fantasy', 2007, 1080)
          ]
    );

    const onShow = (actionType) => {
        setShow(true);
        setActionType(actionType);
    };
    const onHide = () => {
        setShow(false);
    };
    
    const formName = useRef();
    const formAuthor = useRef();
    const formGenre = useRef();
    const formYear = useRef();
    const formPagesCount = useRef();

    const formHandler = (e, actionType) => {
        e.preventDefault();

        const name = (actionType === 'edit') ? 
            null : formName.current.value; //TODO: DODELAY!!
        const author = formAuthor.current.value;
        const genre = formGenre.current.value;
        const year = formYear.current.value;
        const pagesCount = formPagesCount.current.value;
        
        if (actionType === 'add') {
            setBooks([...books, new BookModel(name, author, genre, year, pagesCount)]);
        }
        else if (actionType === 'edit') {
            const index = books.findIndex(element => element.name === name);
            books[index] = new BookModel(name, author, genre, year, pagesCount);
            setBooks([...books]);
        }

        setShow(false);
    };

    const onDelete = (name) => {
        setBooks(books.filter(element => element.name !== name));
    };
    const onEdit = (name) => {
        onShow('edit');
    }

    const value = {
        show,
        setShow,
        onShow,
        onHide,
        formName,
        formAuthor,
        formGenre,
        formYear,
        formPagesCount,
        formHandler,
        actionType,
        setActionType,
        books,
        setBooks,
        onDelete,
        onEdit
    };
    return (
        <Context.Provider value={value}>
            {children}
        </Context.Provider>
    );
};

export {Context, ContextProvider};