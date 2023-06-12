function submitEvents() {
    $('#formLogin').on('submit', function (event) {
        event.preventDefault();
        let username = $("#formLogin input[name=username]").val();
        let password = $("#formLogin input[name=pass]").val();
        requester.loginUser(username, password);
    });
};