(function () {
    "use strict";
    angular
        .module("RoadrunnerApp")
        .controller("SettingsUserSettingController", ["$scope", "settingsUserSettingsResource", "$log", settingsUserSettingController]);

    function settingsUserSettingController($scope, settingsUserSettingsResource, $log) {

        var vm = (function (data) {
            $scope.UserSettings = data;
        });
    }
}());