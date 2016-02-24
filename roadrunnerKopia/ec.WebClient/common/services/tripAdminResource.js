(function () {
    "use strict";

    angular
    .module("common.services")
    .factory("tripAdminResource",
    ["$resource", "appSettings",
    tripAdminResource])

    //tripAdminServices.$inject = ["$resource"];

    //function tripAdminServices($resource, appSettings) {
    //    return $resource(appSettings.serverPath + "api/admin/approved");
    //};
    function tripAdminResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "api/admin/searchtrips/:id", null,
        {
            "update": { method: "PUT" }

        });
    };
}());