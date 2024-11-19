document.addEventListener('DOMContentLoaded', () => {
    loadColors();

    document.getElementById('colorForm').addEventListener('submit', (e) => {
        e.preventDefault();
        const name = document.getElementById('colorName').value.trim();
        const type = document.getElementById('colorType').value;
        const code = document.getElementById('colorCode').value.trim();

        const nameError = validateName(name);
        const codeError = validateCode(type, code);

        if (nameError || codeError) {
            document.getElementById('nameError').textContent = nameError || '';
            document.getElementById('codeError').textContent = codeError || '';
            return;
        }

        const colors = getColors();
        if (colors.some(color => color.name.toLowerCase() === name.toLowerCase())) {
            document.getElementById('nameError').textContent = 'Ця назва вже існує.';
            return;
        }

        colors.push({ name, type, code });
        setColors(colors);
        displayColors(colors);
        clearForm();
    });
});

function validateName(name) {
    const nameRegex = /^[A-Za-zА-Яа-яІіЇїЄєҐґ]+$/;
    if (!name) return 'Обов\'язкове поле';
    if (!nameRegex.test(name)) return 'Назва може містити лише літери.';
    return '';
}

function validateCode(type, code) {
    switch (type) {
        case 'RGB':
            const rgbRegex = /^(25[0-5]|2[0-4][0-9]|[1][0-9]{2}|[1-9]?[0-9]),(25[0-5]|2[0-4][0-9]|[1][0-9]{2}|[1-9]?[0-9]),(25[0-5]|2[0-4][0-9]|[1][0-9]{2}|[1-9]?[0-9])$/;
            return !rgbRegex.test(code) ? 'Неправильний код кольору RGB.' : '';
        case 'RGBA':
            const rgbaRegex = /^(25[0-5]|2[0-4][0-9]|[1][0-9]{2}|[1-9]?[0-9]),(25[0-5]|2[0-4][0-9]|[1][0-9]{2}|[1-9]?[0-9]),(25[0-5]|2[0-4][0-9]|[1][0-9]{2}|[1-9]?[0-9]),(0(\.\d+)?|1(\.0+)?)$/;
            return !rgbaRegex.test(code) ? 'Неправильний код кольору RGBA.' : '';
        case 'HEX':
            const hexRegex = /^#([0-9A-Fa-f]{6})$/;
            return !hexRegex.test(code) ? 'Неправильний код кольору HEX.' : '';
        default:
            return 'Оберіть тип кольору.';
    }
}

function loadColors() {
    const colors = getColors();
    displayColors(colors);
}

function getColors() {
    const colors = Cookies.get('colors');
    console.log('Отримані кольори з куки:', colors); // Відлагоджувальне повідомлення
    return colors ? JSON.parse(colors) : [];
}

function setColors(colors) {
    const expiryDate = new Date(Date.now() + 3 * 60 * 60 * 1000).toUTCString(); // 3 години
    Cookies.set('colors', JSON.stringify(colors), { expires: 1/8 }); // Змінено на 1/8 дня (3 години)
    console.log('Список кольорів збережено в куки:', colors); // Відлагоджувальне повідомлення
}

function displayColors(colors) {
    const colorList = document.getElementById('colorList');
    colorList.innerHTML = '';
    colors.forEach(color => {
        const li = document.createElement('li');
        li.textContent = `${color.name} (${color.type}): ${color.code}`;
        colorList.appendChild(li);
    });
}

function clearForm() {
    document.getElementById('colorForm').reset();
    document.getElementById('nameError').textContent = '';
    document.getElementById('codeError').textContent = '';
}
