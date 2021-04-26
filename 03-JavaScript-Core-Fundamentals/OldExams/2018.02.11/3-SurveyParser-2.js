function solve(input) {
    let svgRegex = /<svg>((.|\n)*?)<\/svg>/g;
    let catRegex = /<cat><text>((.|\n)*?)\[((.|\n)*?)]((.|\n)*?)<\/text><\/cat>\s*<cat>((.|\n)*?)<\/cat>/g;
    let votingRegex = /<g><val>([0-9]+)<\/val>([0-9]+)<\/g>/g;

    if (!svgRegex.test(input)) {
        console.log('No survey found');
    } else if (!catRegex.test(input)) {
        console.log('Invalid format');
    } else {
        catRegex = /<cat><text>((.|\n)*)\[((.|\n)*)]((.|\n)*)<\/text><\/cat>\s*<cat>((.|\n)*)<\/cat>/g;
        let surveyLabel = catRegex.exec(input)[3];

        //let votingRegex = /<g><val>([1-9]|10)<\/val>(\d+)<\/g>/g;
        let totalVotes = 0;
        let totalPoints = 0;
        let votingData = votingRegex.exec(input);
        while (votingData){
            if(-1 < votingData[1] > 10){
                votingData = votingRegex.exec(input);
                continue;
            }
            totalVotes += +votingData[2];
            totalPoints += +votingData[1] * +votingData[2];

            votingData = votingRegex.exec(input);
        }

        let rating = +((totalPoints / totalVotes).toFixed(2));
        console.log(`${surveyLabel}: ${rating}`)
    }
}

solve('<p>Some random text</p><svg><cat><text>How do you rate our food? [Food - General]</text></cat><cat><g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g></cat></svg><p>Some more random text</p>');
solve('<svg><cat><text>How do you rate the special menu? [Food - Special]</text></cat> <cat><g><val>1</val>5</g><g><val>5</val>13</g><g><val>10</val>22</g></cat></svg>');
// solve('<p>Some random text</p><svg><cat><text>How do you rate our food? [Food - General]</text></cat><cat><g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g></cat></svg><p>Some more random text</p>');