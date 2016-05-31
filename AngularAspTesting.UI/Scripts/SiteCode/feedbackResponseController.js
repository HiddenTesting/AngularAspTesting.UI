(function () {

    var app = angular.module("feedbackApp");

    app.controller("feedbackResponseController", ['$scope', '$location', 'feedbackResponseService',
        function ($scope, $location, feedbackResponseService) {
            $scope.AwaitingData = false;
            $scope.FeedbackResponse = null;

            $scope.GetFeedbackResponse = function () {
                var id = $location.search().id;
                
                $scope.AwaitingData = true;

                feedbackResponseService.Get(id)
                    .then(function (response) {
                        $scope.AwaitingData = false;

                        $scope.FeedbackResponse = response.data;
                    }, function (error) {
                        //TODO
                    });
            };

            $scope.GetFeedbackResponse();
        }]);
}());