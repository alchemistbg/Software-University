function solve(input) {
    let regex = /^[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]+$/;
    if (regex.test(input)){
        console.log('Valid')
    }else{
        console.log('Invalid')
    }
}

solve('valid@email.bg');
solve('invalid@emai1.bg');