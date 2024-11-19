import { Container } from "react-bootstrap";

import { BookItem } from "./BookItem";
import { NavBar } from "./NavBar";
import { MyModal } from "./MyModal";

import { Context } from "./Context";
import { useContext } from "react";
import { MyTable } from "./MyTable";

const Library = () => {
    const { books } = useContext(Context);

    return (
        <Container style={{
            width: '80%'
        }}>
            <NavBar />
            <MyTable />
            <MyModal />
        </Container>
    );
};

export { Library };