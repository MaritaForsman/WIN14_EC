(function () {
    "use strict";
    angular
        .module("RoadrunnerApp")
        .controller("SettingsItineraryCtrl", ["settingsItineraryResource", settingsItineraryCtrl]);

    function settingsItineraryCtrl (settingsItineraryResource){
    
        var vm = this;
        settingsItineraryResource.query(function (data) {
            vm.settingsitinerarys = data;
        }); 
    }
}());

