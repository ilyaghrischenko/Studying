import {Table, Row, Col} from 'react-bootstrap';
import { TableTools } from './TableTools';
import {TableBooksRow} from './TableBooksRow';

const TableBooks = ({books}) => {
    return (
        <Row>
            <Col xs={12}>
                <h2>Книги</h2>
            </Col>
            
            <TableTools/>
            
            <Col xs={12}>
                <Table striped bordered hover>
                    <thead>
                        <tr>
                            <th>№ пп</th>
                            <th>Навза</th>
                            <th>Ім'я автора</th>
                            <th>Рік видавництва</th>
                            <th>Назва видавництва</th>
                            <th>К-ть сторінок</th>
                            <th>К-ть примірників</th>
                        </tr>
                    </thead>
                    <tbody>
                        {books.map((elem, index) => <TableBooksRow key = {index} {...elem} />)}
                    </tbody>
                </Table>
            </Col>
        </Row>
    );
};

export { TableBooks };