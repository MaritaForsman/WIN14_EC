(function () {
    "use strict";
    angular
    .module("common.services")
    .factory("settingsItineraryResource",
          ["$resource",
        settingsItineraryResource]);

    function settingsItineraryResource($resource) {
        return $resource("/api/settings/itinerary/:InstvarId")
    }
}());