(fu 'use strict';
angular.module('RoadrunnerApp').controller('TripController', ['$scope', '$http', '$window', 'DataService', TripController]);

TripController.$inject = ['$scope', '$http', '$window', 'DataService'];

function TripController($scope, $http, $window, DataService) {
    var vm = this;
    vm.serverPath = DataService.serverPath;
    vm.cars = [];
    vm.purposes = [];
    vm.routes = [];
    vm.projects = [];
    vm.departments = [];
    var tripDay = {
        personId: '',
        date: new Date(),
        car: '',
        mileageStart: '',
        mileageOut: '',
        purpose: '',
        route: '',
        project: '',
        privateDriving: false,
        userId: 0,
        department: '',
        hasDepartment: false
    }
        

    DataService.getUser('TEA1').then(function (data) {
        if (data.status == 0) {
            vm.userAccount = data.data;
            tripDay.personId = vm.userAccount.UserId + " " + vm.userAccount.Name;
            tripDay.userId = vm.userAccount.UserId;

            DataService.getCars().then(function (data) {
                if (data.status == 0) {
                    vm.cars = data.data;
                }
            });

            DataService.getPurposes(vm.userAccount.UserId).then(function (data) {
                if (data.status == 0) {
                    vm.purposes = data.data;
                }
                    
            });

            DataService.getRoutes(vm.userAccount.UserId).then(function (data) {
                if (data.status == 0)
                {
                    vm.routes = data.data;
                }
                    
            });

            DataService.getProjects(vm.userAccount.UserId).then(function (data) {
                if (data.status == 0)
                {
                    vm.projects = data.data;
                }
                    
            });

            DataService.getDepartments().then(function (data) {
                if (data.status == 0) {
                    vm.departments = data.data;
                }

            });
        }
        else if (data.status == 1) {
            alert("Användaren finns inte");
        }
        else if (data.status == 2) {
            alert(data.data);
        }
    });

    $scope.changeCar = function () {
        for (var index = 0; index < vm.cars.length; ++index) {
            if (vm.cars[index].Number == vm.tripDay.car.Number) {
                tripDay.mileageStart = vm.cars[index].Mileage;
                index = vm.cars.length;
            }
        }

    }

    $scope.changeProject = function () {
        for (var index = 0; index < vm.projects.length; ++index) {
            if (vm.projects[index].Id == vm.tripDay.project.Id) {
                tripDay.department = vm.projects[index].Department;
                if (tripDay.department == null)
                {
                    tripDay.hasDepartment = true;
                }
                    
            }
        }

    }

       

    $scope.submit = function () {
        if ($scope.tripDay.$invalid) {
            return;
        }
        var trip = vm.tripDay;
        trip.car = trip.car.Number;
        trip.project = trip.project.UserProjectId;
        trip.purpose = trip.purpose.Description;
        trip.route = trip.route.Description;
        if (trip.hasDepartment) {
            trip.department = trip.department.DepartmentId;
        }
                        
        DataService.saveTrip(trip).then(function (data) {
            if (data != undefined) {
                   
                  
                    
            }
            else {
                alert("Fel");
            }
        });

    }

    $scope.clear = function () {
            
    }

    vm.tripDay = tripDay;


}

}());