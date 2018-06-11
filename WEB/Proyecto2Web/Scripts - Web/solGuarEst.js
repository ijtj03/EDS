

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
                });
        });
    $scope.enviarForm = function (idForm) {
        var p;
        var date = new Date();
        var month = date.getMonth();
        if (month > 6) {
            p = "II";
        } else {
            p = "I";
        }
        const url = $scope.config.MyApi + "api/Formularios/EnviarForm?IdFormulario=" + idForm + "&Periodo=" + p + "&IdCarnet=" + window.localStorage.getItem("idCarnet");
        $http.get(url)
            .then(function successCallback(response) {
                alert("Su solicitud se ha enviado");
            }, function errorCallback(response) {
                alert("Ha ocurrido un erro intentelo mas tarde");

                console.log(ip);
                console.log(body);
            });
    }
});