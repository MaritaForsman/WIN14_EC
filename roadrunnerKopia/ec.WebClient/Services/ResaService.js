(function () {
    var resaService = function ($http, $q, $log) {
        var cachedResor
        var resor = function () {
            if (cachedResor)
                return $q.when(cachedResor);

            return $http.get("/api/resor")
                .then(function (serviceResp) {
                    cachedResor = serviceResp.data;
                    return serviceResp.data;
                });
        };
        var singleResa = function (id) {
            return $http.get("/api/resor"+id)
                        .then(function (serviceResp) {
                            return serviceResp.data;
                        });
        };

        var insertResa = function (resa) {
            return $http.post("/api/resor", resa)
            .then(function (result)
            {
                $log.info("Insert Successful");
                cachedResor = result.data;
                return result;
            });
        };

        var modifyProject = function (resa) {
            return $http.put("/api/resor" + bil.resa.ID, resa)
            .then(function (result) {
                $log.info("Update Successful");
                cachedResor = result.data;
                return;
            });
        };

        var deleteResa = function (resa) {
            return $http.delete("/api/resor"+bil.resa.ID)
            .then(function (result) {
                $log.info("Delete Successful");
                cachedResor = result.data;
                return result.data;
            });
        };

        return {
            resor: resor,
            singleResa: singleResa,
            insertResor: insertResor,
            modifyResor: modifyResor,
            deleteResor: deleteResor
        };
    };

    var module = angular.module("KörJournalApp");

    module.factory("ResaService", ["$http", "$q", "$log", resaService]);
}());
