'use strict';

new Promise((resolve, reject) => {
    const users = new XMLHttpRequest();

    users.open('GET', 'https://jsonplaceholder.typicode.com/users');
    users.setRequestHeader('Content-Type', 'application/json');

    users.addEventListener('readystatechange', () => {
        if (users.readyState === 4 && users.status === 200) {
            resolve(users.response);
        }

        if (users.readyState === 4 && users.status === 404) {
            reject('Error 404');
        }
    });
    users.send();
})
    .then(response => JSON.parse(response))
    .then(data => console.dir(data))
    .catch(error => console.error(error));