let assert = require('chai').assert;

class SoftUniFy {
    constructor() {
        this.allSongs = {};
    }

    downloadSong(artist, song, lyrics) {
        if (!this.allSongs[artist]) {
            this.allSongs[artist] = {rate: 0, votes: 0, songs: []}
        }

        this.allSongs[artist]['songs'].push(`${song} - ${lyrics}`);

        return this;
    }

    playSong(song) {
        let songArtists = Object.keys(this.allSongs).reduce((acc, cur) => {

            let songs = this.allSongs[cur]['songs']
                .filter((songInfo) => songInfo
                    .split(/ - /)[0] === song);

            if(songs.length > 0){
                acc[cur] = songs;
            }

            return acc;
        }, {});

        let arr = Object.keys(songArtists);
        let output = "";

        if(arr.length > 0){

            arr.forEach((artist) => {
                output += `${artist}:\n`;
                output += `${songArtists[artist].join('\n')}\n`;
            });

        } else {
            output = `You have not downloaded a ${song} song yet. Use SoftUniFy's function downloadSong() to change that!`
        }

        return output;
    }

    get songsList() {
        let songs = Object.values(this.allSongs)
            .map((v) => v['songs'])
            .reduce((acc, cur) => {
                return acc.concat(cur);
            }, []);

        let output;

        if (songs.length > 0) {
            output = songs.join('\n');
        } else {
            output = 'Your song list is empty';
        }

        return output;

    }

    rateArtist() {
        let artistExist = this.allSongs[arguments[0]];
        let output;

        if (artistExist) {

            if (arguments.length === 2) {
                artistExist['rate'] += +arguments[1];
                artistExist['votes'] += 1;
            }

            let currentRate = (+(artistExist['rate'] / artistExist['votes']).toFixed(2));
            isNaN(currentRate) ? output = 0 : output = currentRate;

        } else {
            output = `The ${arguments[0]} is not on your artist list.`
        }

        return output;
    }
}

describe('', function () {
    let testC;
    beforeEach(function () {
        testC = new SoftUniFy();
    });

    describe('Basic', function () {
        it('check object creation', function () {
            assert.instanceOf(testC, SoftUniFy);
            assert.property(testC, 'allSongs');
            assert.property(testC, 'downloadSong');
            assert.property(testC, 'playSong');
            assert.property(testC, 'songsList');
            assert.property(testC, 'rateArtist');
        });
    });

    describe('downloadSong', function () {
        it('check downloadSong', function () {
            let result = testC.downloadSong('');
        });

    });

    describe('playSong', function () {
        it('check playSong', function () {
            let result = testC.playSong('Test');
            let expect = `You have not downloaded a Test song yet. Use SoftUniFy's function downloadSong() to change that!`
            assert.equal(result, expect);
        });

    });

    describe('songsList', function () {
        it('check songsList', function () {
            let result = testC.songsList('');
        });

    });

    describe('check rateArtist', function () {
        it('should return Not in...', function () {
            let result = testC.rateArtist('AB');
            let expect = 'The AB is not on your artist list.';
            assert.equal(result, expect);
        });
        it('should return smth', function () {
            testC.downloadSong('Eminem', 'Venom', 'Knock, Knock let the devil in...');

            //let Result =
        });
    });
});