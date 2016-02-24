(function () {
    "use strict";
    angular
        .module("RoadrunnerApp")
        .controller("SettingCtrl", SettingCtrl);

    function SettingCtrl() {
        var vm = this;
        vm.instvags = [
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
            }];
        vm.instorsaks = [
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
            }
        ]
        vm.instprojs = [
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
        ]
    }
}());