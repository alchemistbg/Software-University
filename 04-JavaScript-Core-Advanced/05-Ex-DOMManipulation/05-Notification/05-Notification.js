function notify(message) {
    let messDiv = document.getElementById('notification');
    messDiv.textContent = message;
    messDiv.style.display = 'block';

    setTimeout(() => {
        messDiv.style.display = 'none';
    }, 2000);
}