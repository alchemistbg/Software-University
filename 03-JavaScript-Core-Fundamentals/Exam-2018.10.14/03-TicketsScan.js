function solve(input, output) {
    let passangerNames = '';
    let namesRegex2 = / ([A-Z][A-Za-z]*?)-([A-Z][A-Za-z]*?) /g;
    let namesRegex3 = /([A-Z][A-Za-z]*?)-([A-Z][A-Za-z]*?\.)-([A-Z][A-Za-z]*?) /g;

    if (namesRegex2.test(input)){
        passangerNames = input.match(namesRegex2)[0].replace(/-/g, ' ').trim();
        //console.log(passangerNames[0].replace(/-/g, ' ').trim());
    }else if (namesRegex3.test(input)){
        passangerNames = input.match(namesRegex3)[0].replace(/-/g, ' ').trim();
        //console.log(passangerNames);
    }

    let airports = [];
    let airportRegex = / ([A-Z]{3})\/([A-Z]{3}) /g;
    if (airportRegex.test(input)){
        airports = input.match(airportRegex)[0].trim().split('/');
        //console.log(airports)
    }

    let flightNumber = '';
    let flightRegex = / [A-Z]{1,3}[0-9]{1,5} /g;
    if (flightRegex.test(input)){
        flightNumber = input.match(flightRegex)[0].trim();
        //console.log(flightNumber)
    }

    let companyName = '';
    let companyRegex = /- [A-Z][A-Za-z]*\*[A-Z][A-Za-z]* /;
    if (companyRegex.test(input)){
        companyName = input.match(companyRegex)[0].replace('- ', '').replace(/\*/g, ' ').trim();
        //console.log(companyName)
    }

    switch (output) {
        case 'name':
            console.log(`Mr/Ms, ${passangerNames}, have a nice flight!`);
            break;
        case 'flight':
            console.log(`Your flight number ${flightNumber} is from ${airports[0]} to ${airports[1]}.`)
            break;
        case 'company':
            console.log(`Have a nice flight with ${companyName}.`)
            break;
        case 'all':
            console.log(`Mr/Ms, ${passangerNames}, your flight number ${flightNumber} is from ${airports[0]} to ${airports[1]}. Have a nice flight with ${companyName}.`);
            break;
    }
}

solve('ahah Second-Testov )*))&&ba SOF/VAR ela** FB973 - Bulgaria*Air -opFB900 pa-SOF/VAr//_- T12G12 STD08:45  STA09:35 ', 'all');
console.log();
solve(' TEST-T.-TESTOV   SOF/VIE OS806 - Austrian*Airlines T24G55 STD11:15 STA11:50 ', 'flight');