const bookList = document.getElementById('book-list');
let lastSelectedIndex = null;

bookList.addEventListener('click', function(event) {
    if (event.target.tagName === 'LI') {
        const clickedBook = event.target;
        const clickedIndex = Array.from(bookList.children).indexOf(clickedBook);

        if (event.shiftKey && lastSelectedIndex !== null) {
            const start = Math.min(lastSelectedIndex, clickedIndex);
            const end = Math.max(lastSelectedIndex, clickedIndex);

            for (let i = start; i <= end; i++) {
                bookList.children[i].classList.add('selected');
            }
        } else if (event.ctrlKey) {
            clickedBook.classList.toggle('selected');
        } else {
            Array.from(bookList.children).forEach(item => item.classList.remove('selected'));
            clickedBook.classList.add('selected');
        }

        lastSelectedIndex = clickedIndex;
    }
});
