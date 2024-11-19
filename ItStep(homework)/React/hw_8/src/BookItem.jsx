import { Button } from "react-bootstrap";
import { RiDeleteBin5Fill } from "react-icons/ri";
import { MdEditSquare } from "react-icons/md";

import { Context } from "./Context";
import { useContext } from "react";

const BookItem = ({ name, author, genre, year, pagesCount }) => {
    const { onDelete, onEdit } = useContext(Context);

    return (
        <tr>
            <td>{name}</td>
            <td>{author}</td>
            <td>{genre}</td>
            <td>{year}</td>
            <td>{pagesCount}</td>

            <div
                style={{
                    display: 'flex',
                    flexDirection: 'row',
                    gap: '5px'
                }}>
                <Button
                    className="btn-nav"
                    variant="primary"
                    onClick={() => onEdit(name)}
                    style={{
                        width: '80%'
                    }}
                >
                    <MdEditSquare />
                </Button>
                
                <Button
                    className="btn-nav"
                    variant="danger"
                    onClick={() => onDelete(name)}
                    style={{
                        width: '80%'
                    }}
                >
                    <RiDeleteBin5Fill />
                </Button>

            </div>
        </tr>
    );
};

export { BookItem };