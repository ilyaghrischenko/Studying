'use strict';

const users = new XMLHttpRequest();

users.open('GET', 'https://jsonplaceholder.typicode.com/users');
users.setRequestHeader('Content-Type', 'application/json');

users.addEventListener('readystatechange', () => {
    if (users.readyState === 4 && users.status === 200) {
        let data = JSON.parse(users.response);
        console.dir(data);
    }

    if (users.readyState === 4 && users.status === 404) {
       console.error('Error 404');
    }

});
users.send();
