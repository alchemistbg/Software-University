const user = (function(){
    const getLogin = function(ctx){
        ctx.partial('views/user/login.hbs');
    };

    const postLogin = function(ctx){
        var username = ctx.params.username;
        var password = ctx.params.pass;
        
        userModel.login(username, password).done(function(data){
            storage.saveUser(data);

            notification.info("Login succesful.");
            ctx.redirect('#/');
        }).fail(function(){
            notification.error("Invalid username or passwrod.");
            //$()
        });
    };

    const logout = function(ctx){
        userModel.logout().done(function(){
            storage.deleteUser();
            
            notification.info("Logout succesful.");
            ctx.redirect('#/login');
        }).fail(function(){
            notification.error("Logout problems.");
            ctx.redirect('#/');
        });
    }

    const getRegister = function(ctx) {
        ctx.partial('views/user/register.hbs');
    };

    const postRegister = function(ctx) {
        userModel.register(ctx.params).done(function(data){
            storage.saveUser(data);

            ctx.redirect('#/');
        });
    };

    const initializeLogin = function(){
        if(userModel.isAuthorized()){
            $("#logged-user-name").text(storage.getData('userInfo').username);
            $(".hidden-when-logged-in").addClass("d-none");
            $(".hidden-when-logged-out").removeClass("d-none");
        } else {
            $(".hidden-when-logged-in").removeClass("d-none");
            $(".hidden-when-logged-out").addClass("d-none");
        }
    };

    return {
        getLogin,
        postLogin,
        logout,
        getRegister,
        postRegister,
        initializeLogin
    };
}());