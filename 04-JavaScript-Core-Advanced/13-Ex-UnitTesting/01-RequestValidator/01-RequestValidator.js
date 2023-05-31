function solve(request) {
    let error = 'Invalid request header: Invalid ';
    let methods = ['GET', 'POST', 'DELETE', 'CONNECT'];
    let versions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];

    if (!methods.includes(request.method)) {
        error += 'Method'
        throw new Error (error);
    }
    
    if (!request.hasOwnProperty('uri') || request.uri.length === 0 || /[^A-Za-z0-9\.]/g.test(request.uri)) {
        error += 'URI';
        throw new Error(error);
    }

    if (!versions.includes(request.version)) {
        error += 'Version'
        throw new Error (error);
    }

    if (!request.hasOwnProperty('message')) {
        error += 'Message';
        throw new Error (error);
    } else {
        if (/[\<\>\\\&\'\"]/g.test(request.message)){
            error += 'Message';
            throw new Error (error);
        }
    }

    return request;
}

let request = {
    method: 'GET',
    uri: '#gerg',
    version: 'HTTP/1.1',
    message: 'asl<pls'
};
//     {
//     method: 'GET',
//     uri: 'svn.public.catalog',
//     version: 'HTTP/1.1',
//     message: ''
// };

console.log(solve(request));
