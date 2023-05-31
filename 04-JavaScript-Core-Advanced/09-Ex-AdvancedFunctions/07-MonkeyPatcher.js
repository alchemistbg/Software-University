function solve(input) {
    let that = this;
    switch (input) {
        case 'upvote':
            that.upvotes += 1;
            break;
        case 'downvote':
            that.downvotes += 1;
            break;
        case 'score':
            return score(that);
            break;
    }

    function score(that) {
        let uVotes = that.upvotes;
        let dVotes = that.downvotes;
        let sumVotes = uVotes + dVotes;
        let inflation = 0;
        if (sumVotes > 50) {
            inflation = Math.ceil(Math.max(uVotes, dVotes) * 0.25);
        }
        let scoreVote = uVotes - dVotes;
        let rating = '';
        if (sumVotes >= 10) {
            let ratio = Math.ceil(uVotes / sumVotes * 100);
            if (ratio > 66) {
                rating = 'hot';
            } else if (scoreVote >= 0 && (uVotes > 100 || dVotes > 100)) {
                rating = 'controversial';
            } else if (scoreVote < 0) {
                rating = 'unpopular';
            } else {
                rating = 'new';
            }

        } else {
            rating = 'new';
        }
        return [uVotes + inflation, dVotes + inflation, scoreVote, rating];
    }
}

let post = {
    id: '1234',
    bookAuthor: 'bookAuthor bookName',
    content: 'these fields are irrelevant',
    upvotes: 4,
    downvotes: 5
};
// solve.call(post, 'upvote');
// solve.call(post, 'downvote');
let score = solve.call(post, 'score'); // [127, 127, 0, 'controversial']
/*for (let i = 0; i < 50; i++) {
    solve.call(post, 'downvote'); //…        // (executed 50 times)
}
score = solve.call(post, 'score');     // [139, 189, -50, 'unpopular']*/
console.log(score)
