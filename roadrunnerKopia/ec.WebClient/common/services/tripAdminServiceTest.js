(function () {
    "use strict";
    angular
        .module("common.services")
        .factory("TripAdminServiceTest", ["$http", tripAdminServiceTest]);

    this.GetAll = function () {
        var req = $http.get("api/admin/searchtrips");
        return req;
    };
    this.GetNotApproved = function () {
        var req = $http.get("api/admin/approved");
        return req;
    };
    this.NewTripAdmin = function () {
        var req = $http.post("api/admin/create")
        return req;
    }

    //var tripAdminServiceTest = function ($http) {
    //    var trips = function () {
    //        return $http.get("http://localhost:1433/api/trips")
    //        .then(function (tripResp) {
    //            return tripResp.data;
    //        });
    //    };
    //    var tripsApprove = function ($http) {
    //        return $http.get("http://localhost:1433/api/trips/approve")
    //        .then(function (tripsapprove) {
    //            return tripsapprove
    //        });
    //    };
    //    return {
    //        trips: trips,
    //        tripsApprove: tripsApprove
    //    }
    //};

}());