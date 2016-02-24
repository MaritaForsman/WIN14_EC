(function () {
    "use strict";
    angular
        .module("common.services")
        .factory("TripAdminService", ["$http", tripAdminService]);

    var tripAdminService = function($http){
        var trips = function () {
            return $http.get("http://localhost:1433/api/trips")
            .then(function (tripResp) {
                return tripResp.data;
            });
        };
        var tripsApprove = function ($http) {
            return $http.get("http://localhost:1433/api/trips/approve")
            .then(function (tripsapprove) {
                return tripsapprove
            });
        };
        return {
            trips: trips,
            tripsApprove: tripsApprove
        }
    };

}());