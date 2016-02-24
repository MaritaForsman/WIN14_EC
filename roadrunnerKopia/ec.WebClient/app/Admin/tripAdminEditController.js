(function () {
    "use strict";
    angular
        .module("RoadrunnerApp")
        .controller("tripAdminEditController",
                        tripAdminEditController);

    function tripAdminEditController(tripAdminService) {
        var vm = this;
        vm.trip = {};
        vm.message = "";

        tripResource.get(id, function (data) {
            vm.trip = data;
            vm.orginalTrip = angular.copy(data)
        });
        
        vm.sumbit = function () {
            vm.message = "";
            if (vm.trip.IdNr) {
                vm.trip.$update({ id: vm.trip.IdNr },
                function (data) {
                    vm.message = "......Uppdateringen klar";
                })
            }
            else {
                vm.trip.$save(
                function (data) {
                    vm.orginalTrip = angular.copy(data);
                    vm.message = "....Ny resa tillagd"
                })
            }
        };
        vm.cancel = function (editForm) {
            editForm.$setPristine();
            vm.trip = angular.copy(vm.orginalTrip);
            vm.message = "";
        };

        vm.open = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();

        vm.opened = !vm.opened;
    };
    }
    
}());