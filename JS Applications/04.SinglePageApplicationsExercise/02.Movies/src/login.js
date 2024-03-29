import { homePage } from './home.js';
import { showView, updateNav } from './util.js';

const loginSection = document.querySelector('#form-login');
const form = loginSection.querySelector('form');
form.addEventListener('submit', onSubmit);

export function loginPage() {
    showView(loginSection);
}

async function onSubmit(ev) {
    ev.preventDefault();

    const formData = new FormData(form);
    const email = formData.get('email');
    const password = formData.get('password');

    await login(email, password);
    form.reset();
    updateNav();
    homePage();
}

async function login(email, password) {
    try {
        const response = await fetch('http://localhost:3030/users/login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ email, password })
        });

        if (!response.ok) {
            const error = await response.json();
            throw new Error(error.message);
        }

        const user = await response.json();
        localStorage.setItem('user', JSON.stringify(user));
    } catch (err) {
        alert(err.message);
        throw err;
    }
}