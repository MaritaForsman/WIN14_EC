(function () {
    "use strict";

    angular
    .module("common.services")
    .factory("tripAdminServices",
    ["$resource", "appSettings",
    tripAdminServices])

    //tripAdminServices.$inject = ["$resource"];

    //function tripAdminServices($resource, appSettings) {
    //    return $resource(appSettings.serverPath + "api/admin/approved");
    //};
    function tripAdminServices($resource, appSettings) {
        return $resource(appSettings.serverPath + "api/admin/searchtrips/:id", null,
        {
            "update": { method: "PUT" }
            
        });
    };
}());