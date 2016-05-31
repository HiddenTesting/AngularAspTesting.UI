(function () {
    var app = angular.module('feedbackApp');

    app.factory('feedbackService', ['$http', function ($http) {
        var apiAddress = '/api/Feedback/';

        this.GetApplicationClose = function () {
            return $http.get(apiAddress);
        };

        this.SubmitEnterFeedbackData = function (model) {
            return $http.post(apiAddress, angular.toJson(model));
            //.then(function () {});
        };
        
        return this;
    }]);
}());