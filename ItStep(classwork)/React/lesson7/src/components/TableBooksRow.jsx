const TableBooksRow = ({ id, author, title, publishing, year, pages, count }) => {
    return (
        <tr>
            <td>{id}</td>
            <td>{title}</td>
            <td>{author}</td>
            <td>{year}</td>
            <td>{publishing}</td>
            <td>{pages}</td>
            <td>{count}</td>
        </tr>
    );
};

export {TableBooksRow};