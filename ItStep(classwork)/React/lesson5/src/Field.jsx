import { CounterContext } from "./Context";
import { useContext } from "react";

const Field = () => {
    const {counter} = useContext(CounterContext);

    return (
        <div className = "counter__field">{counter}</div>
    );
};

export default Field;