(function () {
    "use strict";
    var app = angular
                .module("settingsProjectMock",
                        ["ngMockE2E"]);

    app.run(function ($httpBackend) {

        var settingsprojects = [
            {
                "ProjId": 345,
                "ShowProj": "true"
            },
            {
                "ProjId": 2,
                "ShowProj": "true"
            },
            {
                "ProjId": 3,
                "ShowProj": "false"
            }
        ];

        var productUrl = "/api/usersettings/project"

        $httpBackend.whenGET(productUrl).respond(settingsprojects);

        $httpBackend.whenGET(/app/).passThrough();
    })
}());