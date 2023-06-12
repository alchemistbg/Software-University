const notification = (function(){
    const info  = function(text){
        $("#infoBox").show();
        $("#infoBox > span").text(`${text}`);
        setTimeout(() => {
            $("#infoBox").fadeOut();
        }, 3000);
    };

    const error  = function(text){
        $("#errorBox").show();
        $("#errorBox > span").text(`${text}`);
        setTimeout(() => {
            $("#errorBox").fadeOut();
        }, 3000);
    };

    return {
        info,
        error
    }
}());