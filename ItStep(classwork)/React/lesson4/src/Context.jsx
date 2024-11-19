import { createContext, useEffect, useReducer, useState } from 'react';

export const TodoContext = createContext();

const reducer = (todo, action) => {
    switch (action.type) {
        case 'ADD_TODO': {
            const newTodo = { id: Date.now(), title: action.payload, status: false };
            return [...todo, newTodo];
        }
        case 'REMOVE_TODO': {
            return todo.filter(item => item.id !== action.payload);
        }
        case 'EDIT_TODO': {
            return todo.map(item => {
                if (item.id === action.payload) {
                    return { ...item, status: !item.status };
                }
                return item;
            });
        }
        case 'LOAD_TODOS': {
            return [...action.payload];
        }
        default: {
            return todo;
        }
    }
};

export default function Context(props) {
    const [todo, dispatch] = useReducer(reducer, []);
    const [message, setMessage] = useState('');

    useEffect(() => {
        const storedTodos = localStorage.getItem('todos');
        if (storedTodos) {
            dispatch({ type: 'LOAD_TODOS', payload: JSON.parse(storedTodos) });
        }
    }, []);

    useEffect(() => {
        if (todo.length > 0) {
            localStorage.setItem('todos', JSON.stringify(todo));
        }
    }, [todo]);

    const handlerAddTodo = (e) => {
        e.preventDefault();

        if (e.target.mytodo.value === '') {
            setMessage('Please enter a task');
            return;
        }

        if (todo.find(item => item.title === e.target.mytodo.value)) {
            setMessage('This task already exists');
            return;
        }

        dispatch({ type: "ADD_TODO", payload: e.target.mytodo.value });
        e.target.mytodo.value = '';
    };

    const handlerDeleteTodoItem = (key) => {
        dispatch({ type: "REMOVE_TODO", payload: key });
        if (todo.length === 0) {
            localStorage.removeItem('todos');
        }
    };

    const handlerSelectTodoItem = (key) => {
        dispatch({ type: "EDIT_TODO", payload: key });
    };

    const value = {
        todo,
        handlerAddTodo,
        handlerDeleteTodoItem,
        handlerSelectTodoItem,
        message,
        setMessage
    };

    return (
        <TodoContext.Provider value={value}>
            {props.children}
        </TodoContext.Provider>
    );
}
