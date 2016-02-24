(function () {
    "use strict";
    angular
    .module("common.services")
    .factory("settingsPurposeResource",
          ["$resource", "appSettings",
        settingsPurposeResource]);

    function settingsPurposeResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "api/usersettings/purposes/:userid")
    }
}());