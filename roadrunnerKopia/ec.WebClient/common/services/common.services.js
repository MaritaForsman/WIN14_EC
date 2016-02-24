///Reusable code for all pages///

(function () {
    "use strict";
    angular
       .module("common.services", ["ngResource"])
       .constant("appSettings",
       {
           serverPath: "http://localhost:1433/"
       });
    ///Close menu after selection///

    $(document).on('click.nav', '.navbar-collapse.in', function (e) {
        if ($(e.target).is('a')) {
            $(this).removeClass('in').addClass('collapse');
        }
    });
    

}());