///angular main code page ///
///app-module and view routing to layoutpage (index.html) ////

(function () {
    "use strict";
    var app = angular.module("RoadrunnerApp",
        ["common.services",
            "ui.router",
            "ui.bootstrap"]);

    app.config(["$stateProvider",
            "$urlRouterProvider",
            function ($stateProvider, $urlRouterProvider) {
                $urlRouterProvider.otherwise("/");

                $stateProvider
                    //.state("home", {
                    //    url: "/",
                    //    templateUrl: "app/welcomeView.html"
                    //})
                    .state("tripDay", {
                        url: "/trips",
                        templateUrl: "app/mobile/tripDayView.html",
                        controller: "TripController"
                    })
                    //.state("tripWeek", {
                    //    url: "/trip",
                    //    templateUrl: "app/mobile/tripWeekView.html",
                    //    controller: "TripDagCtrl as vm"
                    //})
                    .state("usersettings", {
                        url: "/usersettings",
                        templateUrl: "app/mobile/settingsView.html",
                        //controller: "SettingCtrl as vm"
                    })
                     .state("usersettings.route", {
                         url: "^api/usersettings/routes",
                         templateUrl: "app/mobile/settingsRouteEditView.html",
                         controller: "settingsRouteController as vm"
                     })
                    .state("usersettings.purpose", {
                        url: "^api/usersettings/purpose",
                        templateUrl: "app/mobile/settingsPurposeEditView.html",
                        controller: "settingsPurposeController as vm"
                    })
                    //.state("settings.project", {
                    //    url: "/project",
                    //    templateUrl: "app/mobile/settingsProjectEditView.html",
                    //    controller: "SettingsProjectCtrl as vm"
                    //})
                    .state("approveTrip", {
                        url: "api/admin/approved",
                        templateUrl: "app/Admin/tripAdminApproveView.html",
                        controller: "tripAdminApproveController as vm"
                    })
                    .state("editTrip", {
                        url: "api/admin/update",
                        templateUrl: "app/Admin/regTripAdminView.html",
                        controller: "tripAdminEditController as vm"
                    })
                    .state("searchTrip", {
                        url: "api/admin/searchtrips",
                        templateUrl: "app/Admin/tripAdminSearchView.html",
                        controller: "tripAdminController as vm"
                    })

                //.state("login", {
                //    url: "/",
                //    templateUrl: "login.html"
                //})
            }]
    );
}());