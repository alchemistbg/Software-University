const requester = (function () {

    const baseURL = 'https://baas.kinvey.com/';
    const appKey = 'kid_Syu-KlXlE';
    const appSecret = '4ba001f795cb4141bb89d030e35c02e4';
    const authHeader = {
        'Authorization': "Basic " + btoa(appKey + ":" + appSecret)
    };

    const loginUser = function (username, password) {
        $.ajax({
            method: 'POST',
            url: baseURL + 'user/' + appKey + '/login',
            headers: authHeader,
            data: {
                username,
                password
            }
        }).then(function (res) {
            signInUser(res, 'Login successful.');
            $('#formLogin').trigger('reset');
            setNavBarView();
            showForm("viewRegister");
        }).catch(handleError);
    };

    // const registerUser = function(data){
    //     $.ajax({

    //     }).then({

    //     }).catch(handleError);
    // };

    function signInUser(res, message) {
        saveUserSession(res);
        //showInfo(message);
        //showHomeView();
        //showHideLinks();
    }

    function saveUserSession(userInfo) {
        sessionStorage.setItem('authToken', userInfo._kmd.authtoken);
        sessionStorage.setItem('username', userInfo.username);
        sessionStorage.setItem('userId', userInfo._id);
    }

    function handleError(err) {
        console.log(err.responseJSON.description);
        
    }

    return {
        loginUser
    };
}());