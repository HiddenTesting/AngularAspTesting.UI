(function () {
    var app = angular.module('feedbackApp');

    app.factory('enterFeedbackService', ['$http', function ($http) {
        var apiAddress = '/api/EnterFeedback/';
        
        this.SubmitEnterFeedbackData = function (model) {
            return $http.post(apiAddress, angular.toJson(model));
        };
        
        return this;
    }]);
}());