function toggle() {
    let curButtonText = document.getElementsByClassName('button')[0].textContent;
    if (curButtonText === 'More'){
        document.getElementsByClassName('button')[0].textContent = 'Less';
        document.getElementById('extra').style.display = 'block';
    } else {
        document.getElementsByClassName('button')[0].textContent = 'More';
        document.getElementById('extra').style.display = 'none';
    }
}