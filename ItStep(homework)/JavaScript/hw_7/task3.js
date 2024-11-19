const headers = document.querySelectorAll('.accordion-header');

headers.forEach(header => {
    header.addEventListener('click', () => {
        headers.forEach(h => {
            if (h !== header) {
                h.classList.remove('active');
                h.nextElementSibling.style.display = 'none';
            }
        });

        const content = header.nextElementSibling;
        if (content.style.display === 'block') {
            content.style.display = 'none';
            header.classList.remove('active');
        } else {
            content.style.display = 'block';
            header.classList.add('active');
        }
    });
});
