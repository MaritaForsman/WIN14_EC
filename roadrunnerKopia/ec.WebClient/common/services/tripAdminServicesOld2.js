(function () {
    "use strict";
    angular
        .module("common.services")
        .factory("tripAdminService", ["$http", "$q","$log",tripAdminService]);

    var tripAdminService = function ($http, $log, $g) {
        var cachedTrips;

        var trips = function () {
            if (cachedTrips)
                return $g.when(cachedTrips);

            return $http.get("http://localhost:1433/api/admin")
            .then(function (tripResp) {
                return tripResp.data;
            });
        };
        var tripsApprove = function () {
            return $http.get("http://localhost:1433/api/admin/approved")
            .then(function (tripsapprove) {
                return tripsapprove
            });
        };
        //var trips = function () {
        //    return $http.get("http:
        
        
        
        st:1433/api/trips")
        //    .then(function (tripsResp) {
        //        return tripsResp
        //    });
        //};
        var NewTripAdmin = function (trip) {
            return $http.get("http://localhost:1433/api/admin/create", trip)
            .then(function (result) {
                $log.info("Insert Successful");
                cachedTrips = result.data;
                return result;
            });
        };
        return {
            trips: trips,
            NewTripAdmin: NewTripAdmin
        }
    }
}());