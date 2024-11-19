import { useState, useEffect } from "react";

const CurrentTime = () => {
    const [time, setTime] = useState(new Date().toLocaleTimeString());

    const tick = () => {
        setTime(new Date().toLocaleTimeString());
    };

    useEffect(() => {
        const intervalID = setInterval(tick, 1000);
        return () => clearInterval(intervalID);
    }, []);

    return (
        <div>func: {time}</div>
    );
};

export {CurrentTime};