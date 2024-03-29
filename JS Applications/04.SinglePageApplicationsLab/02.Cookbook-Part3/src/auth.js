const userNavigation = document.querySelector('#user');
const guestNavigation = document.querySelector('#guest');

export function updateAuth() {
    let serializedUser = localStorage.getItem('user');
    if (serializedUser) {
        //let user = JSON.parse(serializedUser);
        guestNavigation.style.display = 'none';
        userNavigation.style.display = 'inline';
    } else {
        guestNavigation.style.display = 'inline';
        userNavigation.style.display = 'none';
    }
}

export function logout() {
    localStorage.removeItem('user');
    updateAuth();
}

export function getToken() {
    let serializedUser = localStorage.getItem('user');
    if (serializedUser) {
        let user = JSON.parse(serializedUser);

        return user.accessToken;
    }
}