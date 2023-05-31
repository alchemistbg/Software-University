function addItem(){
    let text = document.getElementById('newItemText').value;
    let value = document.getElementById('newItemValue').value;
    let newItem = document.createElement('option');
    newItem.textContent = text;
    newItem.value = value;
    document.getElementById('menu').appendChild(newItem);

    document.getElementById('newItemText').value = '';
    document.getElementById('newItemValue').value = '';
}