(function () {
    "use strict";
    var app = angular
                .module("tripMock",
                        ["ngMockE2E"]);

    app.run(function ($httpBackend) {
        var trips = [
            {
                "IdNr": 1,
                "Datum": "2015-08-26",
                "Ing": 78998,
                "Utg": 98874,
                "Bil": "ABS135",
                "Projekt": 1234,
                "Objekt": 999,
                "Kstnr": 123,
                "Bolag": 123,
                "Anr": 1,
                "Privat": false,
                "Godkand": false
            },
            {
                "IdNr": 2,
                "Datum": "2015-08-26",
                "Ing": 78998,
                "Utg": 98874,
                "Bil": "ABC456",
                "Projekt": 1234,
                "Objekt": 999,
                "Kstnr": 123,
                "Bolag": 123,
                "Anr": 1,
                "Privat": false,
                "Godkand": false
            },
            {
                "IdNr": 3,
                "Datum": "2015-08-26",
                "Ing": 78998,
                "Utg": 98874,
                "Bil": "CCC455",
                "Projekt": 1234,
                "Objekt": 999,
                "Kstnr": 123,
                "Bolag": 123,
                "Anr": 1,
                "Privat": false,
                "Godkand": false
            },
            {
                "IdNr": 9,
                "Datum": "2015-08-26",
                "Ing": 98874,
                "Utg": 99741,
                "Bil": "ABS135",
                "Projekt": 1234,
                "Objekt": 999,
                "Kstnr": 123,
                "Bolag": 123,
                "Anr": 2,
                "Privat": false,
                "Godkand": false
            },
        ];

        var tripUrl = "/api/admin/trip"

        $httpBackend.whenGET(tripUrl).respond(trips);

        $httpBackend.whenGET(/app/).passThrough();
    })
}());
