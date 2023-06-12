const flightModel = (function () {

    const flightURL = `appdata/${storage.appKey}/flights`;

    const getFlights = function(public){
        let publicURL = flightURL +'/?query={"isPublic":true}';

        return requester.get(publicURL);
    };
    
    const add = function (params) {
        let data = {
            "destination": params.destination,
            "origin": params.origin,
            "departure": params.departureDate,
            "departureTime": params.departureTime,
            "seats": params.seats,
            "cost": params.seats,
            "image": params.img,
            "isPublic": !!params.public
        };

        return requester.post(flightURL, data);
    };
    

    return {
        add,
        getFlights
    };
}());