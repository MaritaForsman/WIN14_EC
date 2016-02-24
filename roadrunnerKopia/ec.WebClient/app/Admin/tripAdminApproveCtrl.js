(function () {
    "use strict";
    angular
        .module("RoadrunnerApp")
        .controller("tripAdminApproveCtrl", tripAdminApproveCtrl);

    tripAdminApproveCtrl.$inject = [ "$scope", "$http"]
    function tripAdminApproveCtrl( $scope, $http) {
        $http.get("api/admin/approved").success(function (data) {
            $scope.approved = data;
        });
    }
        //tripAdminResource.query(function (data) {
        //    vm.trips = data;
        //});
    
})();