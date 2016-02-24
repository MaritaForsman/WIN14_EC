(function () {
    "use strict";
    angular
    .module("common.services")
    .factory("SettingResource", ["$resource", settingResource]);

    function settingResource($resource) {
        return $resource("/api/setting/")
    }
}());