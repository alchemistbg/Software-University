function solve(input) {
    //<svg>(<cat><text>.+\[(.+)\]<\/text><\/cat>)(<cat>.+<\/cat>)<\/svg>
    let globalRegex = /<svg>(.+)<\/svg>/gm;
    let globalMatch = globalRegex.exec(input);
    if (!globalMatch) {
        console.log('No survey found');
        return;
    } else {
        let surveyData = globalMatch[1];
        let dataRegex = /<cat><text>.+\[(.+)\]<\/text><\/cat>\s*<cat>(<g><val>.+<\/val>.+<\/g>)<\/cat>/g;
        let surveyMatch = dataRegex.exec(surveyData);
        if (!surveyMatch) {
            console.log('Invalid format');
            return;
        } else {
            let surveyLabel = surveyMatch[1];
            let votingRegex = /<g><val>([1-9]|10)<\/val>(\d+)<\/g>/g;
            let votingMatches = surveyMatch[2].match(votingRegex);
            let totalPoints = 0;
            let totalVotes = 0;
            for (let i = 0; i < votingMatches.length; i++) {
                let curVoteRegex = /<g><val>([1-9]|10)<\/val>(\d+)<\/g>/g;
                let curVoteResult = curVoteRegex.exec(votingMatches[i]);
                let curPoints = +curVoteResult[1] * +curVoteResult[2];
                totalPoints += curPoints;
                totalVotes += +curVoteResult[2];
            }

            console.log(`${surveyLabel}: ${+((totalPoints / totalVotes).toFixed(2))}`)
        }
    }
}

solve('<p>Some random text</p><svg><cat><text>How do you rate our food? [Food - General]</text></cat><cat><g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g></cat></svg><p>Some more random text</p>');
solve('<svg><cat><text>How do you rate the special menu? [Food - Special]</text></cat> <cat><g><val>1</val>5</g><g><val>5</val>13</g><g><val>10</val>22</g></cat></svg>');
// solve('<p>Some random text</p><svg><cat><text>How do you rate our food? [Food - General]</text></cat><cat><g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g></cat></svg><p>Some more random text</p>');