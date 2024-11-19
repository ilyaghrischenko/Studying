const textContainer = document.getElementById('text-container');
const textArea = document.getElementById('edit-textarea');
let isEditing = false;

document.addEventListener('keydown', function(event) {
    if (event.ctrlKey && event.key === 'e') {
        event.preventDefault();

        if (!isEditing) {
            textArea.value = textContainer.textContent;
            textContainer.style.display = 'none';
            textArea.style.display = 'block';
            textArea.focus();
        } else {
            textContainer.textContent = textArea.value;
            textArea.style.display = 'none';
            textContainer.style.display = 'block';
        }
        
        isEditing = !isEditing;
    }

    if (event.ctrlKey && event.key === 's') {
        event.preventDefault();

        if (isEditing) {
            textContainer.textContent = textArea.value;
            textArea.style.display = 'none';
            textContainer.style.display = 'block';
            isEditing = false;
        }
    }
});
