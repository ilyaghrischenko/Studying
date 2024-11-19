import { BookItem } from "./BookItem";
import { Table, Card } from "react-bootstrap";

import { Context } from "./Context";
import { useContext } from "react";

const MyTable = () => {
    const { books } = useContext(Context);

    return (
        <Card>
            <Table>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Author</th>
                        <th>Genre</th>
                        <th>Year</th>
                        <th>Pages Count</th>
                    </tr>
                </thead>
                <tbody>
                    {books.map((book, index) => (
                        <BookItem key={index} {...book} />
                    ))}
                </tbody>
            </Table>
        </Card>
    );
};

export { MyTable };