(function () {
    var app = angular.module("feedbackApp", ['ngRoute']);

    app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider
            // Home
            .when("/", { templateUrl: "Templates/EnterFeedback", controller: "feedbackEnterController" })
            .when("/ConfirmFeedback", { templateUrl: "Templates/ConfirmFeedback", controller: "feedbackConfirmController" })

            //404
            .otherwise("/NotFound", { templateUrl: "Templates/NotFound" })
        ;

        $locationProvider.html5Mode(true);
    }]);
}());