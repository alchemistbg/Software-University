function subtract(){
    let fN = document.getElementById('firstNumber').value;
    let sN = document.getElementById('secondNumber').value;
    let diff = fN - sN;
    document.getElementById('result').textContent = diff;
}