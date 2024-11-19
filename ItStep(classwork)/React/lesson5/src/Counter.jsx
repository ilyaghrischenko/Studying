import BtnMinus from "./BtnMinus";
import BtnPlus from "./BtnPlus";
import Field from "./Field";

const Counter = ({counter, setCounter}) => {
    return (
        <div className="counter">
            <BtnMinus
                counter = {counter}
                setCounter = {setCounter}/>
            <Field 
                counter = {counter}/>
            <BtnPlus 
                counter = {counter}
                setCounter = {setCounter}/>
        </div>
    );
};

export default Counter;