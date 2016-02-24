(function () {
    "use strict";
    angular
        .module("common.services")
        .factory("TripResource", ["$resource", tripResource]);

    function tripResource($resource) {
        return $resource("/api/admin/trip/:IdNr")
    }
}());