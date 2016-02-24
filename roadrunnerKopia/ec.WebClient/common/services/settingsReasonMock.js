(function () {
    "use strict";

    var app = angular
                .module("settingsReasonMock",
                        ["ngMockE2E"]);

    app.run(function ($httpBackend) {
        var settingsreasons = [
            {
               "InstOrsakId": 1,
               "Beskrivning": "Project",
               "ShowOrsak": "true"
             },
            {
                "InstOrsakId": 2,
                "Beskrivning": "Möte",
                "ShowOrsak": "true"
            },
            {
                "InstOrsakId": 3,
                "Beskrivning": "Mässa",
                "ShowOrsak": "false"
            },
        ];

        var reasonUrl = "/api/settings/reason"

        $httpBackend.whenGET(reasonUrl).respond(settingsreasons);

        $httpBackend.whenGET(/app/).passThrough();
    })
}());