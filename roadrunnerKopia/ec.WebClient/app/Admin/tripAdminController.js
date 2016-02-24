(function () {
    "use strict";
    angular
        .module("RoadrunnerApp")
        
        .controller("tripAdminController", ["tripAdminResource", tripAdminController]);

    function tripAdminController(tripAdminResource) {
        var vm = this;

        tripAdminResource.query(function (data) {
            vm.trips = data;
            
        });
    }
   

}());