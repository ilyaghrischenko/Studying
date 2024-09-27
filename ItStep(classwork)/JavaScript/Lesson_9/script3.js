'use strict';

fetch('https://jsonplaceholder.typicode.com/users')
    .then(response => {
        if (response.status !== 200) {
            throw new Error(`${response.status}`);
        }
        return response.json();
    })
    .then(data => {
        let div = document.createElement('div');
        div.classList.add('list-group');

        data.forEach(elem => {
            let btn = document.createElement('button');
            btn.setAttribute('type', 'button');
            btn.classList.add('list-group-item');
            btn.classList.add('list-group-item-action');
            btn.textContent = elem.name;

            btn.addEventListener('click', () => {
                let phoneDiv = document.getElementById('phone-number');
                phoneDiv.textContent = `Phone: ${elem.phone}`;
            });

            div.insertAdjacentElement('beforeend', btn);
        });

        document.querySelector('.content .col-3').insertAdjacentElement('afterend', div);
    })
    .catch(error => console.error(error));
