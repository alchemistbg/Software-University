const flight = (function(){

    const addFlightGet = function(ctx){
        ctx.partial('views/flight/add.hbs');
    };

    const addFlightPost = function(ctx){
        flightModel.add(ctx.params).done(function(){
            notification.info('Created flight.');
            ctx.redirect('#/');
        }).fail(function(){
            notification.error('Some error occured!');
        });
    };

    const editFlight = function(){

    };

    const deleteFlight = function(){

    };

    return {
        addFlightGet,
        addFlightPost,
        editFlight,
        deleteFlight
    };
}());