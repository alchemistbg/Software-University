function attachGradientEvents(){
    let grBox = document.getElementById('gradient');
    grBox.addEventListener('mousemove', (evt) => {
        // let pos = evt.offsetX / (evt.target.clientWidth - 1);
        let pos = evt.offsetX / (evt.target.clientWidth);
        pos = Math.trunc(pos * 100);
        document.getElementById('result').textContent = pos + '%';
        console.log(pos);
    });
    grBox.addEventListener('mouseout', () => {
        document.getElementById('result').textContent = '';
    });
}