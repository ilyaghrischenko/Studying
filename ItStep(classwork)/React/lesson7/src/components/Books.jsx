import { MyAlert } from './MyAlert';
import { TableBooks } from './TableBooks';
import {useSelector} from 'react-redux';

const Books = () => {
    const books = useSelector(state => state);

    if (!books) {
        return (
            <MyAlert
                head = "Книги"
            >
                Список книг наразі порожній
            </MyAlert>
        );
    }

    return (
        <TableBooks books={books} />
    );
}

export {Books}