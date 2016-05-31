(function () {
    var app = angular.module("feedbackApp", ['ngRoute']);

    app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider
            // Home
            .when("/", { templateUrl: "Templates/EnterFeedback", controller: "enterFeedbackController" })
            .when("/FeedbackConfirm", { templateUrl: "Templates/FeedbackResponse", controller: "feedbackResponseController" })

            //404
            .otherwise("/NotFound", { templateUrl: "Templates/NotFound" })
        ;

        $locationProvider.html5Mode(true);
    }]);
}());