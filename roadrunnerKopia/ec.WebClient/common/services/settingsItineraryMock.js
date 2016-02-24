(function () {
    "use strict";
    var app = angular
                .module("settingsItineraryMock",
                        ["ngMockE2E"]);

    app.run(function ($httpBackend) {

        var settingsitinerarys = [
            {
                "InstVagId": 1,
                "Resvag": "KHamn - Lund - KHamn",
                "ShowResvag": true
            },
            {
                "InstVagId": 2,
                "Resvag": "KHamn - Malmö - KHamn",
                "ShowResvag": true
            },
            {
                "InstVagId": 3,
                "Resvag": "KHamn - Lund - KHamn",
                "ShowResvag": false
            },
        ];

        var itineraryUrl = "/api/settings/itinerary"

        $httpBackend.whenGET(itineraryUrl).respond(settingsitinerarys);

        $httpBackend.whenGET(/app/).passThrough();
    })
}());