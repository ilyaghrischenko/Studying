document.querySelectorAll('a[href^="http://"]').forEach(link => {
    link.classList.add('external-link');
});
