function clickEvents() {
    $("#alchLoginButton").on('click', function () {
        hideForms();
        $("#viewLogin").show();
    });
    $("#alchRegisterButton").on('click', function () {
        hideForms();
        $("#viewRegister").show();
    });
}