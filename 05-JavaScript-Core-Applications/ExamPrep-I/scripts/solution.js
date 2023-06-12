function start() {
    console.log("SPA started");

    //sessionStorage.clear();
    hideAll();

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

    function formatDate(idate) {
        const monthNames = [
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        ];
        let odate = new Date(idate);
        return odate.getDate() + ' ' + monthNames[odate.getMonth()];

    }

    $(document).on('ajaxStart', function () {
        $("#loadingBox").show();
    });
    $(document).on('ajaxStop', function () {
        $("#loadingBox").hide();
    });

    $(".left-container > ul > li").eq(0).on('click', getPublicFlights);
    $(".left-container > ul > li").eq(1).on('click', getMyFlights);
    $(".left-container > ul > li").eq(2).on('click', showLogin);
    $('#formLogin input[type="submit"]').on('click', performLogin);
    $(".left-container > ul > li").eq(3).on('click', showRegister);
    $('#formRegister input[type="submit"]').on('click', performRegister);
    $('.log-out').on('click', performLogout);
    $('.add-flight').on('click', showAddFlight);
    $('#formAddFlight input[type="submit"]').on('click', performAddFlight);
    $("form").submit(function (event) {
        event.preventDefault();
    });

    function hideAll() {
        $(".left-container > ul > li").eq(0).hide();
        $(".left-container > ul > li").eq(1).hide();
        $(".left-container > ul > li").eq(2).hide();
        $(".left-container > ul > li").eq(3).hide();
        $(".right-container > span").hide();
        $(".log-out").hide();
        $("#viewRegister").hide();
        $("#viewLogin").hide();
        $("#viewCatalog").hide();
        $("#viewAddFlight").hide();
        $("#viewFlightDetails").hide();
        $("#viewEditFlight").hide();
        $("#viewMyFlights").hide();

        showMenuItems();
    }

    function showMenuItems() {
        if (sessionStorage.getItem('authToken')) {
            $(".left-container > ul > li").eq(0).show();
            $(".left-container > ul > li").eq(1).show();
            $(".log-out").show();
            $(".right-container > span").show();
            $(".right-container > span").text(`Welcome, ${sessionStorage.getItem('userName')}`);
        } else {
            $(".left-container > ul > li").eq(2).show();
            $(".left-container > ul > li").eq(3).show();
        }
    }

    function showLogin() {
        hideAll();
        $("#viewLogin").show();
    }

    function performLogin() {
        const username = $('#formLogin input[name="username"]').val();
        const password = $('#formLogin input[name="pass"]').val();

        if (!username || username.length < 5) {
            showMsg('error', 'Username must be at least 5 symbols long!');
        } else if (!password) {
            showMsg('error', 'Password field shouldn’t be empty!');
        } else {
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
                getPublicFlights();
                showMsg('info', 'Login successful.');
                $('#formLogin').trigger('reset');
            }).catch(handleAjaxError);
        }
    }

    function showRegister() {
        hideAll();
        $("#viewRegister").show();
    }

    function performRegister() {
        const username = $('#formRegister input[name="username"]').val();
        const password = $('#formRegister input[name="pass"]').val();
        const passwordCheck = $('#formRegister input[name="checkPass"]').val();

        if (!username || username.length < 5) {
            showMsg('error', 'Username must be at least 5 symbols long!');
        } else if (!password) {
            showMsg('error', 'Password field shouldn’t be empty!');
        } else if (!passwordCheck) {
            showMsg('error', 'Repeat password field shouldn’t be empty!');
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
                getPublicFlights();
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
            showMsg('info', 'Logout successful.');
        }).catch(handleAjaxError);
    }

    function performFlightDelete(id) {
        $.ajax({
            method: "DELETE",
            url: kinveyBaseUrl + 'appdata/' + kinveyAppKey + '/flights/' + id,
            headers: getKinveyUserAuthHeaders()
        }).then(function () {
            showMsg('info', 'Flight deleted.');
            getMyFlights();
        }).catch(handleAjaxError);
    }

    function getPublicFlights() {
        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + "appdata/" + kinveyAppKey + '/flights?query={"isPublic":"true"}',
            headers: getKinveyUserAuthHeaders()
        }).then(function (res) {
            renderPublicFlights(res);
        }).catch(handleAjaxError);
    }

    function renderPublicFlights(flights) {
        hideAll();
        $('#viewCatalog').show();
        $('.added-flights').empty();
        for (const flight of flights) {
            let ahref = $('<a href="#" class="added-flight"></a>').on('click', function () {
                renderFlightDetails(flight);
            });
            ahref
                .append(`<img src="${flight.image}" alt="" class="picture-added-flight">`)
                .append(`<h3>${flight.destination}</h3>`)
                .append(`<span>from ${flight.origin}</span><span>${formatDate(flight.departure)}</span>`)
                .appendTo($('.added-flights'));
        }
    }

    function getMyFlights() {
        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + 'appdata/' + kinveyAppKey + `/flights?query={"_acl.creator":"${sessionStorage.getItem('userId')}"}`,
            headers: getKinveyUserAuthHeaders()
        }).then(function (res) {
            renderMyFlights(res);
        }).catch(handleAjaxError);
    }

    function renderMyFlights(myFlights) {
        hideAll();
        $('#viewMyFlights').show();
        $('#viewMyFlights').empty();
        $('#viewMyFlights').append('<h3>Your Flights</h3>');

        for (const myFlight of myFlights) {
            let myFlightInfo = $('<div class="flight-ticket"></div>');
            let leftArea = $('<div class="flight-left"></div>')
                .append(`<img src="${myFlight.image}" alt="">`);
            let rightArea = $('<div class="flight-right"></div>')
                .append(`<div>
                            <h3>${myFlight.destination}</h3><span>${formatDate(myFlight.departure)}</span>
                        </div>`)
                .append(`<div>
                            from ${myFlight.origin} <span>${myFlight.departureTime}</span>
                        </div>`)
                .append(`<p>${myFlight.seats} Seats (${myFlight.cost}$ per seat) </p>`)
                .append($('<a href="#" class="remove">REMOVE</a>').on('click', function (event) {
                    performFlightDelete(myFlight._id);
                }))
                .append($('<a href="#" class="details">Details</a>').on('click', function (event) {
                    renderFlightDetails(myFlight);
                }));

            myFlightInfo.append(leftArea).append(rightArea);
            $('#viewMyFlights').append(myFlightInfo);
        }
    }

    function renderFlightDetails(flight) {
        hideAll();

        $('#viewFlightDetails').show();
        $('.ticket-area').empty();
        let leftArea = $('<div class="ticket-area-left"></div>')
            .append(`<img src="${flight.image}">`);
        let rightArea = $('<div class="ticket-area-right"></div>')
            .append(`<h3>${flight.destination}</h3>`)
            .append(`<div>from ${flight.origin}</div>`)
            .append(`<div class="data-and-time">
                        ${formatDate(flight.departure)} ${flight.departureTime}
                        <a href="#" class="edit-flight-detail"></a>
                    </div>`)
            .append(`<div>
                        ${flight.seats} Seats (${flight.cost} per seat)
                    </div>`);
        $('.ticket-area').append(leftArea).append(rightArea);

        if (sessionStorage.getItem('userId') === flight._acl.creator) {
            $('.edit-flight-detail').on('click', function () {
                showEditFlight(flight);
            });
        } else {
            $('.edit-flight-detail').hide();
        }
    }

    function showAddFlight() {
        hideAll();
        $('#viewAddFlight').show();
    }

    function performAddFlight() {
        let destination = $('#viewAddFlight input[name="destination"]').val();
        let origin = $('#viewAddFlight input[name="origin"]').val();
        let departure = $('#viewAddFlight input[name="departureDate"]').val();
        let departureTime = $('#viewAddFlight input[name="departureTime"]').val();
        let seats = Number($('#viewAddFlight input[name="seats"]').val());
        let cost = Number($('#viewAddFlight input[name="cost"]').val());
        let image = $('#viewAddFlight input[name="img"]').val();
        let isPublic = $('#viewAddFlight input[name="public"]').is(":checked");

        //data validation
        if (destination.length < 1) {
            showMsg('error', 'Destination shouldn’t be empty.');
        } else if (origin.length < 1) {
            showMsg('error', 'Origin shouldn’t be empty.');
        } else if (+seats <= 0) {
            showMsg('error', 'Number of seats must be positive number.');
        } else if (+cost <= 0) {
            showMsg('error', 'Cost per seat must be positive number.');
        } else {
            $.ajax({
                method: "POST",
                url: kinveyBaseUrl + "appdata/" + kinveyAppKey + "/flights",
                headers: getKinveyUserAuthHeaders(),
                data: {
                    destination,
                    origin,
                    departure,
                    departureTime,
                    seats,
                    cost,
                    image,
                    isPublic
                }
            }).then(function (res) {
                hideAll();
                getPublicFlights();
                showMsg('info', 'Created flight.');
                $('#formAddFlight').trigger('reset');
            }).catch(handleAjaxError);
        }


    }

    function showEditFlight(fToEdit) {
        hideAll();
        $('#viewEditFlight').show();
        $('#formEditFlight').trigger('reset');
        $.ajax({
            method: "GET",
            url: kinveyBaseUrl + 'appdata/' + kinveyAppKey + '/flights/' + fToEdit._id,
            headers: getKinveyUserAuthHeaders()
        }).then(function (res) {
            $('#formEditFlight').attr('flightId', fToEdit._id);
            $('#viewEditFlight input[name="destination"]').val(fToEdit.destination);
            $('#viewEditFlight input[name="origin"]').val(fToEdit.origin);
            $('#viewEditFlight input[name="departureDate"]').val(fToEdit.departure);
            $('#viewEditFlight input[name="departureTime"]').val(fToEdit.departureTime);
            $('#viewEditFlight input[name="seats"]').val(Number(fToEdit.seats));
            $('#viewEditFlight input[name="cost"]').val(Number(fToEdit.cost));
            $('#viewEditFlight input[name="img"]').val(fToEdit.image);
            $('#viewEditFlight input[name="public"]').val(fToEdit.isPublic);
            $('#viewEditFlight input[type="submit"]').on('click', function (event) {
                performEditFlight();
            });
        }).catch(handleAjaxError);
    }

    function performEditFlight() {
        let destination = $('#viewEditFlight input[name="destination"]').val();
        let origin = $('#viewEditFlight input[name="origin"]').val();
        let departure = $('#viewEditFlight input[name="departureDate"]').val();
        let departureTime = $('#viewEditFlight input[name="departureTime"]').val();
        let seats = Number($('#viewEditFlight input[name="seats"]').val());
        let cost = Number($('#viewEditFlight input[name="cost"]').val());
        let image = $('#viewEditFlight input[name="img"]').val();
        let isPublic = $('#viewEditFlight input[name="public"]').is(":checked");

        //TODO datavalidation
        //$('#viewEditFlight input[type="submit"]').on('click', function () {
            $.ajax({
                method: "PUT",
                url: kinveyBaseUrl + 'appdata/' + kinveyAppKey + '/flights/' + `${$('#formEditFlight').prop('flightId')}`,
                headers: getKinveyUserAuthHeaders(),
                data: {
                    destination,
                    origin,
                    departure,
                    departureTime,
                    seats,
                    cost,
                    image,
                    isPublic
                }
            }).then(function (res) {
                renderFlightDetails(res);
                showMsg('info', 'Successfully edited flight.');
            }).catch(handleAjaxError);
        //});


    }
}