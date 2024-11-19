import { CounterContext } from "./Context";
import { useContext } from "react";

const BtnMinus = () => {
    const {handleMinus} = useContext(CounterContext);

    return (
        <button
            className = "counter__btn counter__minus"
            onClick={handleMinus}>
            -
        </button>
    );
};

export default BtnMinus;