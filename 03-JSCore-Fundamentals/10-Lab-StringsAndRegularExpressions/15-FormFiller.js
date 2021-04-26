function solve(uname, email, phone, text) {
    for (let i = 0; i < text.length; i++) {
        text[i] = text[i].replace(/<![a-zA-Z]+!>/g, uname);
        text[i] = text[i].replace(/<@[a-zA-Z]+@>/g, email);
        text[i] = text[i].replace(/<\+[a-zA-Z]+\+>/g, phone);
    }
    console.log(text.join('\n'))
}

solve(
    'Pesho',
    'pesho@softuni.bg',
    '90-60-90',
    [
        'Hello, <!username!>!', 
        'Welcome to your Personal profile.',
        'Here you can modify your profile freely.',
        'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
        'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
        'Your current phone number is: <+number+>. Would you like to change that? (Y/N)'
    ]
);