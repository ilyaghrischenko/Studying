document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('.sortable').forEach(header => {
        header.addEventListener('click', () => {
            const sortField = header.getAttribute('data-sort');
            const sortOrder = header.getAttribute('data-order');
            sortTable(sortField, sortOrder);
            header.setAttribute('data-order', sortOrder === 'asc' ? 'desc' : 'asc');
        });
    });
});

function sortTable(sortField, sortOrder) {
    const tableBody = document.getElementById('authTableBody');
    const rows = Array.from(tableBody.querySelectorAll('tr'));

    rows.sort((a, b) => {
        const aCell = a.querySelector(`td[data-field="${sortField}"]`);
        const bCell = b.querySelector(`td[data-field="${sortField}"]`);

        if (aCell && bCell) {
            const aText = aCell.innerText;
            const bText = bCell.innerText;
            return sortOrder === 'asc' ? aText.localeCompare(bText) : bText.localeCompare(aText);
        }
        return 0;
    });

    tableBody.innerHTML = '';
    rows.forEach(row => tableBody.appendChild(row));
}