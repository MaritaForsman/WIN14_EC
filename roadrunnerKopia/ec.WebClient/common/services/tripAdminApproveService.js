(function () {
    "use strict";

    angular
    .module("common.services")
    .factory("tripAdminApproveServices",
    ["$resource", "appSettings",
    tripAdminApproveServices])

    //tripAdminServices.$inject = ["$resource"];

    function tripAdminApproveServices($resource, appSettings) {
        return $resource(appSettings.serverPath + "api/admin/approved");
    };
    
}());