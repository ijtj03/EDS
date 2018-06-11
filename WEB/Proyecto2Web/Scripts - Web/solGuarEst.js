var mA = angular.module('SolGuarEst', []);

mA.controller('SolGuarEstCtrl', function ($scope, $http) {
    $scope.config;
    $scope.forms;
    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url = $scope.config.MyApi + "api/Formularios/GetFormulariosGuardados?estudiante=" + window.localStorage.getItem("idCarnet");
            console.log(url);
            $http.get(url)
                .then(function (res) {
                    $scope.forms = res.data;
                    cosole.log(res.data);
                });
        });
    
});