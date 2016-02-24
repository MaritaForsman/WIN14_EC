(function () {
    "use strict";
    angular
        .module("RoadrunnerApp")
        .controller("SettingsProjectCtrl",
        ["settingsProjectResource",
            settingsProjectCtrl]);

    function settingsProjectCtrl(settingsProjectResource) {    
        var vm = this;

        settingsProjectResource.query({userid: 1},function (data) {
            vm.settingsprojects = data;
        });
    }
}());

