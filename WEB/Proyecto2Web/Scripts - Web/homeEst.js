var mA = angular.module('HomeEst', []);

mA.controller('HomeEstCtrl', function ($scope, $http) {
    $scope.config;
    $scope.student;
    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url = "http://" + $scope.config.ApiIp + "/APILogin/ce/Students/" + window.localStorage.getItem("idCarnet");
            $http.get(url)
                .then(function (res) {
                    $scope.student = res.data;
                });
        });
    
});