(function () {
    "use strict";
    angular
        .module("RoadrunnerApp")
        .controller("settingsPurposeController", ["settingsPurposeResource", settingsPurposeController]);

    function settingsPurposeController(settingsPurposeResource) {
    
        var vm = this;
        settingsPurposeResource.query({userid:1}, function (data) {
            vm.purposes = data;
            
        });
    }
}());

