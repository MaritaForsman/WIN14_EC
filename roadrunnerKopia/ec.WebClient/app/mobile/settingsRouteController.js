(function () {
    "use strict";
    angular
        .module("RoadrunnerApp")
        .controller("settingsRouteController", ["settingsRouteResource", settingsRouteController]);

    function settingsRouteController(settingsRouteResource) {
        var vm = this;
        settingsRouteResource.query({ userid: 1 }, function (data) {
            vm.routes = data;
        });   
    }
}());