import {createContext, useReducer, useState} from 'react';

export const CounterContext = createContext();

const reducer = (state, action) => {
    switch (action.type) {
        case 'PLUS_COUNTER':
        case 'MINUS_COUNTER':
        default:
    }
}

export default function Context(props) {
    // const [counter, setCounter] = useState(0);
    
    // const handleMinus = () => {
    //     if (counter >= 1) {
    //         setCounter(counter - 1);
    //     } 
    // };
    
    // const handlePlus = () => {
    //     setCounter(counter + 1);
    // };
    
    const [state, reducer] = useReducer(reducer, 1);

    const value = {counter, handleMinus, handlePlus};
    return (
        <CounterContext.Provider value={value}>
            {props.children}
        </CounterContext.Provider>
    );
};