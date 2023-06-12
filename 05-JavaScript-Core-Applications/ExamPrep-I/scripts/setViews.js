function isAuthorized() {
    if (sessionStorage.getItem("authToken")) {
        return true;
    } else {
        return false;
    }
}

function setNavBarView() {
    if (isAuthorized()) {
        $("#alchLoginButton").hide();
        $("#alchRegisterButton").hide();
        $("#alchHomeButton").show();
        $("#alchFlightsButton").show();
        $("#alchWelcome").show();
        $("#alchLogout").show();
    } else {
        $("#alchLoginButton").show();
        $("#alchRegisterButton").show();
        $("#alchHomeButton").hide();
        $("#alchFlightsButton").hide();
        $("#alchWelcome").hide();
        $("#alchLogout").hide();
    }
}

function hideAllForms() {
    $("#viewLogin").hide();
    $("#viewRegister").hide();
    $("#viewCatalog").hide();
    $("#viewAddFlight").hide();
    $("#viewFlightDetails").hide();
    $("#viewEditFlight").hide();
    $("#viewMyFlights").hide();
}

function showForm(selector){
    $(selector).show();
}

