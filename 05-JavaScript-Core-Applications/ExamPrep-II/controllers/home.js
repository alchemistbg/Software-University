 const home = (function(){
    const index = function(ctx) {
        let fl;
        if (userModel.isAuthorized()) {
            fl = flightModel.getFlights(false);
        } else {
            fl = flightModel.getFlights(true);
            //fl = flightModel.getFlights(false);
            //ctx.swap('');
        }
        
        fl.done(function(data){
            ctx.flights = data;
            ctx.partial('views/home/index.hbs');
        });
    };

    return {
        index
    };
}());