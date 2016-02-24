(function (){
    "use strict";
    angular
    .module("common.services")
    .factory("settingsRouteResource", ["$resource", "appSettings", settingsRouteResource])

    function settingsRouteResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "api/usersettings/routes/:userid"
        ,
        {
            "update": { method: "PUT" }
        });

    };

}());

