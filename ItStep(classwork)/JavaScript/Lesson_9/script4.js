'use strict';

const resp = async () => {
    try {
        const resp = await fetch('https://jsonplaceholder.typicode.com/users');
        let response = await resp.json();
        console.dir(response);
    } catch (error) {
        console.log(error);
    } finally {
        console.log('finally');
    }
}

resp();