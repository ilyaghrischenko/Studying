import { Button } from "react-bootstrap";

import { MdAddBox } from "react-icons/md";

import {useContext} from "react";
import { Context } from "./Context";

const NavBar = () => {
    const { onShow } = useContext(Context);

    return (
        <div style={{
            display: 'flex',
            flexDirection: 'row',
            justifyContent: 'end',
            gap: '5px',
            marginBottom: '4px'
        }}>
            <Button
                className="btn-nav"
                variant="success"
                onClick={() => onShow('add')}>
                <MdAddBox />
            </Button>
        </div>
    );
};

export { NavBar };