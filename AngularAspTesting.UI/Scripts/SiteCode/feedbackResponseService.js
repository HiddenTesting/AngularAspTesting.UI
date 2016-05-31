(function () {
    var app = angular.module('feedbackApp');

    app.factory('feedbackResponseService', ['$http', function ($http) {
        var apiAddress = '/api/FeedbackResponse/';
        
        //Returns the details of the entered feedback
        this.Get = function (id) {
            return $http.get(apiAddress + "?id=" + id);
        };
        
        return this;
    }]);
}());