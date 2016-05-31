(function () {

    var app = angular.module("feedbackApp");

    app.controller("enterFeedbackController", ['$scope', '$location', 'enterFeedbackService',
        function ($scope, $location, enterFeedbackService) {
            $scope.AwaitingData = false;
            $scope.feedbackModel = {
                Name: null,
                EmailAddress: null
            };

            $scope.SubmitEnterFeedbackData = function () {
                $scope.AwaitingData = true;

                enterFeedbackService.SubmitEnterFeedbackData($scope.feedbackModel)
                    .then(function (response) {
                        $scope.AwaitingData = false;
                        //console.log(response.data);
                        //Display confirm
                        $location.path('/FeedbackResponse').search('id', response.data);
                    }, function (error) {
                        //TODO
                    });
            };
        }]);
}());