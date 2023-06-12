function start() {
    console.log('SPA started!');

    hideAll();

    const kinveyBaseUrl = "https://baas.kinvey.com/";
    const kinveyAppKey = "kid_r1DhqSYlN";
    const kinveyAppSecret = "38710bea28ae46fca067bc56246f586c";
    const kinveyAppAuthHeaders = {
        'Authorization': "Basic " + btoa(kinveyAppKey + ":" + kinveyAppSecret),
    };

    function saveAuthInSession(userInfo) {
        sessionStorage.setItem('authToken', userInfo._kmd.authtoken);
        sessionStorage.setItem('userId', userInfo._id);
        sessionStorage.setItem('userName', userInfo.username);
    }

    function getKinveyUserAuthHeaders() {
        return {
            'Authorization': "Kinvey " + sessionStorage.getItem('authToken'),
        };
    }

    function showMsg(type, msg) {
        if (type === "error") {
            $('#errorBox').show();
            $('#errorBox > span').text(msg);
            $('#errorBox').on('click', function () {
                $('#errorBox').fadeOut();
            });
        }
        if (type === "info") {
            $('#infoBox').show();
            $('#infoBox > span').text(msg);
            $('#infoBox > span').on('click', function () {
                $('#infoBox').fadeOut();
            });
            setTimeout(function () {
                $('#infoBox').fadeOut();
            }, 3000);
        }
    }

    function handleAjaxError(ajaxError) {
        let errorMsg;
        if (ajaxError.readyState === 0)
            errorMsg = "Cannot connect due to network error.";
        if (ajaxError.responseJSON && ajaxError.responseJSON.description)
            errorMsg = ajaxError.responseJSON.description;
        showMsg('error', errorMsg);
    }

    $(document).on('ajaxStart', function () {
        $("#loadingBox").show();
    });
    $(document).on('ajaxStop', function () {
        $("#loadingBox").hide();
    });

    $('#aLoginBtn').on('click', showLogin);
    $('#aLoginBtnRegForm').on('click', showLogin);
    $('#aPerformLoginBtn').on('click', performLogin);
    $('#aRegisterBtn').on('click', showRegister);
    $('#aRegisterBtnLogForm').on('click', showRegister);
    $('#aPerformRegisterBtn').on('click', performRegister);
    $('#aLogoutBtn').on('click', performLogout);

    $('#aHomeBtn').on('click', function () {
        $('#homeView').show();
    });
    $('#aAllSongsBtn').on('click', getAllSongs);
    $('#aMySongsBtn').on('click', getMySongs);

    $('#aAddSongBtn').on('click', showAddSong);
    $('#aCreateSongBtn').on('click', performAddSong);

    $("form").submit(function (event) {
        event.preventDefault();
    });

    function hideAll() {
        $('#aHomeBtn').hide();
        $('#aAllSongsBtn').hide();
        $('#aMySongsBtn').hide();
        $('#aWelcomeText').hide();
        $('#aLogoutBtn').hide();
        $('#aLoginBtn').hide();
        $('#aRegisterBtn').hide();
        //$('#homeView').hide();
        $('#loginView').hide();
        $('#registerView').hide();
        $('#createSongView').hide();
        $('#mySongsView').hide();
        $('#allSongsView').hide();
        $('.song-container > .song').hide();

        showMenuItems();
    }

    function showMenuItems() {
        if (sessionStorage.getItem('authToken')) {
            $('#aHomeBtn').show();
            $('#aAllSongsBtn').show();
            $('#aMySongsBtn').show();
            $('#aWelcomeText').show();
            $('#aLogoutBtn').show();
            $('#aWelcomeText').text('Welcome, ' + sessionStorage.getItem('userName'));
        } else {
            $('#aLoginBtn').show();
            $('#aRegisterBtn').show();
            $('#homeView').show();
        }
    }

    function showLogin() {
        hideAll();
        $('#homeView').hide();
        $('#loginView').show();
    }

    function performLogin() {
        const username = $('#aFormLogin input[name="username"]').val();
        const password = $('#aFormLogin input[name="password"]').val();

        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "user/" + kinveyAppKey + "/login",
            data: {
                username,
                password
            },
            headers: kinveyAppAuthHeaders
        }).then(function (res) {
            saveAuthInSession(res);
            hideAll();
            $('#homeView').show();
            $('#aNavBarAutoEmpty').hide();
            //TODO - add songs View
            // $('#allSongsView').show();
            showMsg('info', 'Login successful.');
            $('#aFormLogin').trigger('reset');
        }).catch(handleAjaxError);
    }

    function showRegister() {
        hideAll();
        $('#homeView').hide();
        $('#registerView').show();
    }

    function performRegister() {
        const username = $('#aFormRegister input[name="username"]').val();
        const password = $('#aFormRegister input[name="password"]').val();

        if (!username || username.length < 3) {
            showMsg('error', 'Username must be at least 3 symbols long!');
        } else if (!password || password.length < 6) {
            showMsg('error', 'Password must be at least 6 symbols long!');
        } else {
            $.ajax({
                method: "POST",
                url: kinveyBaseUrl + "user/" + kinveyAppKey + "/",
                headers: kinveyAppAuthHeaders,
                data: {
                    username,
                    password
                }
            }).then(function (res) {
                saveAuthInSession(res);
                showMsg('info', 'User registration successful.');
                hideAll();
                $('#homeView').show();
                $('#aNavBarAutoEmpty').hide();
                //TODO - add songs View
                $('#registerForm').trigger('reset');
            }).catch(handleAjaxError);
        }
    }

    function performLogout() {
        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "user/" + kinveyAppKey + "/_logout",
            headers: getKinveyUserAuthHeaders()
        }).then(() => {
            sessionStorage.clear();
            hideAll();
            showLogin();
            showMsg('info', 'Logout successful.');
        }).catch(handleAjaxError);
    }

    function getAllSongs() {
        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + `/songs/?query={}&sort={"likes": -1}`,
            headers: getKinveyUserAuthHeaders()
        }).then(function (res) {
            renderAllSongs(res);
        }).catch(handleAjaxError);
    }

    function renderAllSongs(songs) {
        hideAll();
        $('#homeView').hide();
        $('#aNavBarAutoEmpty').hide();
        $('#allSongsView').show();
        $('.song-container > .song').remove();
        let songContainer = $('.song-container');

        for (const song of songs) {
            let songDiv = $('<div class="song"></div>');
            songDiv.append(`<h5>Title: ${song.title}</h5>`);
            songDiv.append(`<h5>Artist: ${song.artist}</h5>`);
            songDiv.append(`<img class="cover" src="${song.image}"/>`);
            if (sessionStorage.getItem('userId') !== song._acl.creator) {
                songDiv.append(`<p>Likes: ${song.likes}</p>`);
                songDiv.append('<a href="#"><button id="aLikeSongBtn" type="button" class="btn btn-primary mt-4">Like</button></a>')
                    .on('click', function (event) {
                        if (event.target.id === 'aLikeSongBtn') {
                            likeSong(song);
                        }
                    });
            } else {
                songDiv.append(`<p>Likes: ${song.likes}; Listened ${song.listens} times</p>`);
                songDiv.append('<a href="#"><button id="aDeleteSongBtn" type="button" class="btn btn-danger mt-4">Remove</button></a>')
                    .on('click', function (event) {
                        if (event.target.id === 'aDeleteSongBtn') {
                            deleteSong(song);
                        }
                    });

                songDiv.append('<a href="#"><button id="aListenSongBtn" type="button" class="btn btn-success mt-4">Listen</button></a>')
                    .on('click', function (event) {
                        if (event.target.id === 'aListenSongBtn') {
                            listenSong(song);
                        }
                    });
            }
            songContainer.append(songDiv);
        }
        $('#aAddSongBtn').on('click', function () {
            //$('.song-container > .song').hide();
            showAddSong();
        });
    }

    function getMySongs() {
        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + '/songs/?query={}&sort={"likes": -1,"listens": -1}',
            headers: getKinveyUserAuthHeaders()
        }).then(function (res) {
            renderMySongs(res);
        }).catch(handleAjaxError);
    }

    function renderMySongs(songs) {
        hideAll();
        $('#homeView').hide();
        $('#aNavBarAutoEmpty').hide();
        $('#mySongsView').show();
        $('.song-container.song').remove();
        let songContainer = $('.song-container');

        for (const song of songs) {
            if (sessionStorage.getItem('userId') === song._acl.creator) {
                let songDiv = $('<div class="song"></div>');
                songDiv.append(`<h5>Title: ${song.title}</h5>`);
                songDiv.append(`<h5>Artist: ${song.artist}</h5>`);
                songDiv.append(`<img class="cover" src="${song.image}"/>`);
                songDiv.append(`<p>Likes: ${song.likes}; Listened ${song.listens} times</p>`);
                songDiv.append('<a href="#"><button id="aDeleteSongBtnMy" type="button" class="btn btn-danger mt-4">Remove</button></a>')
                    .on('click', function (event) {
                        if (event.target.id === 'aDeleteSongBtnMy') {
                            deleteSong(song, event.target.id);
                        }
                    });
                songDiv.append('<a href="#"><button id="aListenSongBtnMy" type="button" class="btn btn-success mt-4">Listen</button></a>')
                    .on('click', function (event) {
                        if (event.target.id === 'aListenSongBtnMy') {
                            listenSong(song, event.target.id);
                        }
                    });
                songContainer.append(songDiv);
            }
        }
        $('#aAddSongBtn').on('click', function () {
            showAddSong();
        });
    }

    function showAddSong() {
        hideAll();
        $('#homeView').hide();
        $('#aNavBarAutoEmpty').hide();
        $('#createSongView').show();
    }

    function performAddSong() {
        let title = $('#title').val();
        let artist = $('#artist').val();
        let image = $('#imageURL').val();
        let likes = 0;
        let listens = 0;

        //dataValidation
        if (title.length < 6) {
            showMsg('error', 'The title should be at least 6 characters long.');
        } else if (artist.length < 3) {
            showMsg('error', 'The artist should be at least 3 characters long.');
        } else if (!image.startsWith('https://') && !image.startsWith('http://')) {
            showMsg('error', 'The image URL should start with "http://" or "https://".');
        } else {
            $.ajax({
                method: "POST",
                url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/songs",
                headers: getKinveyUserAuthHeaders(),
                data: {
                    title,
                    artist,
                    image,
                    likes,
                    listens
                }
            }).then(function (res) {
                hideAll();
                $('#homeView').hide();
                $('#aNavBarAutoEmpty').hide();
                showMsg('info', 'Song created successfully.');
                $('#aCreateSongForm').trigger('reset');
                getAllSongs();
            }).catch(handleAjaxError);
        }
    }

    function deleteSong(song, eventID) {
        $.ajax({
            method: "DELETE",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/songs/" + song._id,
            headers: getKinveyUserAuthHeaders()
        }).then(function () {
            if(eventID === 'aDeleteSongBtnMy'){
                getMySongs();
            }else{
                getAllSongs();
            } 
            showMsg('info', 'Song removed successfully!');
        }).catch(handleAjaxError);
    }

    function likeSong(song) {
        $.ajax({
            method: "PUT",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/songs/" + song._id,
            headers: getKinveyUserAuthHeaders(),
            data: {
                title: song.title,
                artist: song.artist,
                image: song.image,
                likes: +song.likes + 1,
                listens: song.listens
            }
        }).then(function () {
            getAllSongs();
            showMsg('info', 'Liked!');
        }).catch(handleAjaxError);
    }

    function listenSong(song, eventID) {
        $.ajax({
            method: "PUT",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/songs/" + song._id,
            headers: getKinveyUserAuthHeaders(),
            data: {
                title: song.title,
                artist: song.artist,
                image: song.image,
                likes: song.likes,
                listens: +song.listens + 1
            }
        }).then(function () {
            if(eventID === 'aListenSongBtnMy'){
                getMySongs();
            }else{
                getAllSongs();
            }            
            showMsg('info', `You just listened ${song.title}`);
        }).catch(handleAjaxError);
    }
}