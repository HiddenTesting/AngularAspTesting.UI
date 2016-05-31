(function () {

    var app = angular.module("feedbackApp");

    app.controller("feedbackConfirmController", ['$scope', '$location', 'feedbackService',
        function ($scope, $location, feedbackService) {
            $scope.AwaitingData = false;
            $scope.feedbackModel = {
                Name: null,
                EmailAddress: null
            };

            $scope.SubmitEnterFeedbackData = function () {
                $scope.AwaitingData = true;

                feedbackService.SubmitEnterFeedbackData($scope.feedbackModel)
                    .then(function (response) {
                        $scope.AwaitingData = false;

                        //Display confirm
                        $location.path('/ConfirmFeedback');
                    }, function (error) {
                        //TODO
                    });
            };
        }]);
}());