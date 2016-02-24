(function () {
    "use strict";
    angular
    .module("common.services")
    .factory("settingsProjectResource",
          ["$resource",
        settingsProjectResource]);

    function settingsProjectResource($resource) {
        return $resource("/api/settings/project/:userid")
    }
}());