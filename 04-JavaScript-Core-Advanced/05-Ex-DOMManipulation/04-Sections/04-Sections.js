function create(sentences) {
    for (let i = 0; i < sentences.length; i++) {
        let pElem = document.createElement('p');
        pElem.textContent = sentences[i];
        pElem.style.display = 'none';

        let divElem = document.createElement('div');
        divElem.appendChild(pElem);
        divElem.addEventListener('click', (evt) =>{
            evt.target.childNodes[0].style.display = 'block';
            //divElem.childNodes[0].style.display = 'block';
        })

        document.getElementById('content').appendChild(divElem);
    }
}
