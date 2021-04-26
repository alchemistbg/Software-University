//100/100
function solve(text, delim) {
    console.log(text.split(delim).join('\n'))
}

//100/100
/*function solve(text, delim) {
    let regex = new RegExp('[^' + `${delim}` + ']+', 'gi');
    console.log(text.match(regex).join('\n'))
}*/

solve('One-Two-Three-Four-Five', '-');