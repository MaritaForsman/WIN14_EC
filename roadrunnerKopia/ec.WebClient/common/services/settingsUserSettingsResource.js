(function () {
    "use strict";
    angular
    .module("common.services")
    .factory("settingsUserSettingsResource",
          ["$http",
        settingsUserSettingsResource]);

    function settingsUserSettingsResource($http) {
        return $http.get("http/localhoste:1433/api/usersettings")
        .then(function (usersettings){
            return usersettings.data;
        });
        
    }
}());