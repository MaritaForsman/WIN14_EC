(function () {
    "use strict";
    angular
        .module("RoadrunnerApp")
        
        .controller("tripAdminApproveController", ["tripAdminApproveServices", tripAdminApproveController]);

    function tripAdminApproveController(tripAdminApproveServices) {
        var vm = this;

        tripAdminApproveServices.query(function (data) {
            vm.approve = data;
            
        });
    }
   

}());