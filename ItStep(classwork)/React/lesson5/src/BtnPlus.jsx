import { CounterContext } from "./Context";
import { useContext } from "react";

const BtnPlus = ({counter, setCounter}) => {
    const {handlePlus} = useContext(CounterContext);

    return (
        <button
            className = "counter__btn counter__plus"
            onClick={handlePlus}>
            +
        </button>
    );
};

export default BtnPlus;