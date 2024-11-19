import { Alert } from "react-bootstrap";
import CloseButton from "./CloseButton";
import { TodoContext } from "./Context";
import { useContext } from "react";

export default function DangerMessage() {
    const { message, visible } = useContext(TodoContext);

    if (message === '') {
        return null;
    }

    return (
        <Alert
            variant="danger"
            style={{ position: 'relative' }}
            >
            {message}
            <CloseButton />
        </Alert>
    );
}
