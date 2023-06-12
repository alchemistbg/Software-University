function startApp() {
    sessionStorage.clear();
    hideAll();

    $('#dashboard-btn').on('click', () => allListings());
    $('#my-listings').on('click', myListings);
    $('#register-btn').on('click', registerView);
    $('#register-submit').on('click', registerSubmit);
    $('#login-btn').on('click', loginView);
    $('#login-submit').on('click', loginSubmit);
    $('#logout-btn').on('click', logout);
    $('#create-listing-btn').on('click', createListingView);
    $('#create-listing-submit').on('click', createListing);
    $('#all').on('click', () => allListings());
    $('#cats').on('click', () => allListings("Cat"));
    $('#dogs').on('click', () => allListings("Dog"));
    $('#parrots').on('click', () => allListings("Parrot"));
    $('#reptiles').on('click', () => allListings("Reptile"));
    $('#other').on('click', () => allListings("Other"));


    $("form").submit(function (event) {
        event.preventDefault()
    });

    $(document).on({
        ajaxStart: function () {
            $('#loadingBox').show()
        },
        ajaxStop: function () {
            $('#loadingBox').hide()
        }
    });
    $('#infoBox', '#errorBox').on('click', function () {
        $(this).fadeOut()
    });

    function showInfo(message) {
        $('#infoBox').show();
        $('#infoBox > span').text(message);
        setTimeout(function () {
            $('#infoBox').fadeOut()
        }, 3000)
    }

    function showError(error) {
        $('#errorBox').show();
        $('#errorBox > span').text(error);
        $('#errorBox').on('click', function () {
            $(this).fadeOut()
        })
    }

    function handleAjaxError(response) {
        let errorMsg = JSON.stringify(response);
        if (response.readyState === 0)
            errorMsg = "Cannot connect due to network error.";
        if (response.responseJSON && response.responseJSON.description)
            errorMsg = response.responseJSON.description;
        showError(errorMsg);
    }

    const kinveyBaseUrl = "https://baas.kinvey.com/";
    const kinveyAppKey = "kid_Syu-KlXlE";
    const kinveyAppSecret = "4ba001f795cb4141bb89d030e35c02e4";
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

    function registerView() {
        hideAll();
        $('.basic').hide();
        $('.register').show();
    }

    function registerSubmit() {
        const username = $('.register input[name="username"]').val();
        const password = $('.register input[name="password"]').val();

        if (!username || username.length < 3) {
            showError("Username must be at least 3 symbols");
        } else if (!password || password.length < 6) {
            showError("Password must be at least 6 symbols");
        } else {
            $.ajax({
                method: "POST",
                url: kinveyBaseUrl + "user/" + kinveyAppKey + "/",
                headers: kinveyAppAuthHeaders,
                data: {username, password}
            }).then(function (res) {
                saveAuthInSession(res);
                $('.register form').trigger('reset');
                showHome();
                showInfo('User registration successful.');
                $('#welcome-message').text(`Welcome ${sessionStorage.getItem('userName')}`);
            }).catch(handleAjaxError)
        }
    }

    function showHome() {
        hideAll();
        $('.basic').show();
    }

    function loginView() {
        hideAll();
        $('.basic').hide();
        $('.login').show();
    }

    function loginSubmit() {
        const username = $('.login input[name="username"]').val();
        const password = $('.login input[name="password"]').val();

        if (!username || username.length < 3) {
            showError("Username must be at least 3 symbols");
        } else if (!password || password.length < 6) {
            showError("Password must be at least 6 symbols");
        } else {
            $.ajax({
                method: "POST",
                url: kinveyBaseUrl + "user/" + kinveyAppKey + "/login",
                data: {username, password},
                headers: kinveyAppAuthHeaders
            }).then(function (res) {
                saveAuthInSession(res);
                hideAll();
                showInfo('Login successful.');
                showHome();
                $('.login form').trigger('reset');
                $('#welcome-message').text(`Welcome ${sessionStorage.getItem('userName')}`);
            }).catch(handleAjaxError)
        }
    }

    function logout() {
        $.ajax({
            method: "POST",
            url: kinveyBaseUrl + "user/" + kinveyAppKey + "/_logout",
            headers: getKinveyUserAuthHeaders()
        }).then(() => {
            sessionStorage.clear();
            hideAll();
            showInfo('Logout successful.');
        }).catch(handleAjaxError)
    }

    function hideAll() {
        $('.navbar-dashboard').hide();
        $('.navbar-anonymous').hide();
        $('.basic').hide();
        $('.login').hide();
        $('.register').hide();
        $('.create').hide();
        $('.myPet').hide();
        $('.otherPet').hide();
        $('.deletePet').hide();
        $('.detailsMyPet').hide();
        $('.detailsOtherPet').hide();
        $('.dashboard').hide();
        $('.my-pets').hide();
        showMain();
    }

    function showMain() {
        if (sessionStorage.getItem('authToken') === null) {
            $('.basic').show();
            $('.navbar-anonymous').show();
        } else {
            $('.navbar-dashboard').show();
        }
    }

    function allListings(type) {
        hideAll();
        $('.other-pets-list').empty();
        if (type) {
            $.ajax({
                method: "GET",
                url: kinveyBaseUrl + "appdata/" + kinveyAppKey + `/pets?query={"category":"${type}"}&sort={\"likes\": -1}`,
                headers: getKinveyUserAuthHeaders()
            }).then((res) => {
                res.sort((x, y) => parseInt(y.likes, 10) - parseInt(x.likes, 10));
                for (let item of res) {
                    if (sessionStorage.getItem('userId') !== item._acl.creator) {
                        const listing = $(`<li class="otherPet">
                        <h3>Name: ${item.name}</h3>
                        <p>Category: ${item.category}</p>
                        <p class="img"><img src="${item.imageURL}"></p>
                        <p class="description">${item.description}</p></li>`);

                        const wrapper = $('<div class="pet-info"></div>');

                        wrapper.append($('<a href="#"><button class="button"><i class="fas fa-heart"></i> Pet</button></a>')
                            .on('click', () => pet(item, "dashboard", type)));
                        wrapper
                            .append($('<a href="#"><button class="button">Details</button></a>')
                                .on('click', () => listingDetails(item, "details")));
                        wrapper.append($(`<i class="fas fa-heart"></i> <span>${item.likes}</span>`));

                        $(listing).append(wrapper);
                        listing.appendTo($('.other-pets-list'));
                    }
                }
                $('.dashboard').show();
            }).catch(handleAjaxError);
        } else {
            $.ajax({
                method: "GET",
                url: kinveyBaseUrl + "appdata/" + kinveyAppKey + `/pets?query={}&sort={\"likes\": -1}`,
                headers: getKinveyUserAuthHeaders()
            }).then((res) => {
                res.sort((x, y) => parseInt(y.likes, 10) - parseInt(x.likes, 10));
                for (let item of res) {
                    if (sessionStorage.getItem('userId') !== item._acl.creator) {
                        const listing = $(`<li class="otherPet">
                        <h3>Name: ${item.name}</h3>
                        <p>Category: ${item.category}</p>
                        <p class="img"><img src="${item.imageURL}"></p>
                        <p class="description">${item.description}</p></li>`);

                        const wrapper = $('<div class="pet-info"></div>');

                        wrapper.append($('<a href="#"><button class="button"><i class="fas fa-heart"></i> Pet</button></a>')
                            .on('click', () => pet(item, "dashboard", type)));
                        wrapper
                            .append($('<a href="#"><button class="button">Details</button></a>')
                                .on('click', () => listingDetails(item, "details")));
                        wrapper.append($(`<i class="fas fa-heart"></i> <span>${item.likes}</span>`));

                        $(listing).append(wrapper);
                        listing.appendTo($('.other-pets-list'));
                    }
                }
                $('.dashboard').show();
            }).catch(handleAjaxError);
        }
    }

    function createListingView() {
        hideAll();
        $('.create').show();
    }

    function createListing() {
        const name = $('.create input[name="name"]').val();
        const description = $('.create textarea[name="description"]').val();
        const imageURL = $('.create input[name="imageURL"]').val();
        const category = $('.create select').find(":selected").text();

        $.ajax({
            method: "POST",
            data: {
                name, description, imageURL, category, likes: 0
            },
            headers: getKinveyUserAuthHeaders(),
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/pets"
        }).then(function (res) {
            showInfo('Pet created.');
            allListings();
            $('.create form').trigger('reset');
        }).catch(handleAjaxError);
    }

    function editListing(item) {
        const description = $('.detailsMyPet textarea').val();

        $.ajax({
            method: "PUT",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/pets/" + item._id,
            headers: getKinveyUserAuthHeaders(),
            data: {
                name: item.name, description, imageURL: item.imageURL,
                category: item.category, likes: item.likes
            },
        }).then(function (res) {
            showInfo(`Updated successfully!`);
            allListings()
        }).catch(handleAjaxError);
    }


    function deleteListingView(item) {
        hideAll();
        let section = $('.deletePet');
        section.empty();

        section.append(`<h3>${item.name}</h3>
            <p>Pet counter: <i class="fas fa-heart"></i>${item.likes}</p>
            <p class="img"><img src="${item.imageURL}"></p>`);

        let form = $(`<form action="#" method="POST">
                <p class="description">${item.description}</p>
            </form>`);
        form.append($(`<button class="button">Delete</button>`)
            .on('click', () => deleteListing(item)));
        form.submit(function (event) {
            event.preventDefault()
        });
        section.append(form);
        section.show();
    }

    function deleteListing(item) {
        $.ajax({
            method: "DELETE",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/pets/" + item._id,
            headers: getKinveyUserAuthHeaders()
        }).then(function (res) {
            allListings();
            showInfo('Pet removed successfully!');
        }).catch(handleAjaxError);
    }

    function myListings() {
        hideAll();
        let user_id = sessionStorage.getItem('userId');
        $('.my-pets-list').empty();
        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + `/pets?query={"_acl.creator":"${user_id}"}`,
            headers: getKinveyUserAuthHeaders()
        }).then((res) => {
            for (let item of res) {
                const listing = $(`<li class="myPet">
                        <h3>Name: ${item.name}</h3>
                        <p>Category: ${item.category}</p>
                        <p class="img"><img src="${item.imageURL}"></p>
                        <p class="description">${item.description}</p></li>`);

                const wrapper = $('<div class="pet-info"></div>');

                wrapper.append($(`<a href="#">
                                   </a>`)
                    .on('click', () => deleteListingView(item)).append(`<button class="button">Delete</button>`));
                wrapper.append($(`<a href="#">

</a>`)
                    .on('click', () => listingDetails(item, "edit")).append(`<button class="button">Edit</button>`));
                wrapper.append($(`<i class="fas fa-heart"></i> <span>${item.likes}</span>`));

                $(listing).append(wrapper);
                listing.appendTo($('.my-pets-list'));
            }
            $('.my-pets').show();
            $('.my-pets .myPet').show();
        }).catch(handleAjaxError);
    }

    function listingDetails(item, type) {
        hideAll();
        if (type === "details") {
            let section = $('.detailsOtherPet');
            section.empty();
            section.append(`<h3>${item.name}</h3>`);
            let p = $(`<p>Pet counter: ${item.likes} </p>`);
            p.append($(`<a href="#">
                <button class="button"><i class="fas fa-heart"></i>
                    Pet
                </button></a>`).on('click', () => pet(item, "details")));
            section.append(p);
            section.append($(`<p class="img"><img src="${item.imageURL}"></p>
            <p class="description">${item.description}</p>`));
            section.show();
        } else {
            let section = $('.detailsMyPet');
            section.empty();
            section.append(`<h3>${item.name}</h3>
            <p>Pet counter: <i class="fas fa-heart"></i> ${item.likes}</p>
            <p class="img"><img src="${item.imageURL}">
            </p>`);
            let form = $(`<form action="#" method="POST">
                <textarea type="text" name="description">${item.description}</textarea>
            </form>`);
            form.append($(`<button class="button"> Save</button>`).on('click', () => editListing(item)));
            form.submit(function (event) {
                event.preventDefault()
            });
            section.append(form);
            section.show();
        }
    }

    function pet(item, place, type) {
        $.ajax({
            method: "PUT",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/pets/" + item._id,
            headers: getKinveyUserAuthHeaders(),
            data: {
                name: item.name, description: item.description, imageURL: item.imageURL,
                category: item.category, likes: +item.likes + 1
            },
        }).then(function (res) {
            if (place === "dashboard") {
                allListings(type);
            } else {
                listingDetails(res, "details");
            }
        }).catch(handleAjaxError);
    }
}