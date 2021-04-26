function solve(input) {
    let webLinkRegex = /(w{3})[.]([A-Za-z0-9-]+)[.]([.]?([a-z]+))+/g;
    let matches = input.map(x => x.match(webLinkRegex)).filter(x => x !== null).join('\n');
    return matches;
}

console.log(solve(
    [
    'Join WebStars now for free, at www.web-stars.com',
    'You can also support our partners:',
    'Internet - www.internet.com',
    'WebSpiders - www.webspiders101.com',
    'Sentinel - www.sentinel.-ko'
    ]
));