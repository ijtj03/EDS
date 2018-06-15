

var mA = angular.module('SolEst', []);

mA.controller('SolEstCtrl', function ($scope, $http) {
    $scope.config;
    $scope.forms;
    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url = $scope.config.MyApi + "api/Solicitud/GetAllSolicitudesEstudiante?Estudiante=" + window.localStorage.getItem("idCarnet");
            console.log(url);
            $http.get(url)
                .then(function (res) {
                    $scope.sols = res.data;
                });
        });
    $scope.cancelSol = function (idSol) {
        var motivos = prompt("Explique brevemente los motivos de la cancelacion");
        if (motivos != null) {
            const url = $scope.config.MyApi + "api/Solicitud/CancelarSolicitudEstudiante?IdSolicitud=" + idSol;
            $http.post(url)
                .then(function successCallback(response) {
                    alert("Estamos tramitando su gestion");
                    window.location = $scope.config.WebIp + "/PaginaWeb/verSolicitudesEst.html"
                }, function errorCallback(response) {
                    alert("Ha ocurrido un erro intentelo mas tarde");
                });
        }
    }
    $scope.repSol = function (idSol) {
        const url = $scope.config.MyApi + "api/Solicitud/ReplicarSolicitud?IdSolicitud=" + idSol;
        $http.post(url)
            .then(function successCallback(response) {
                alert("Replica realizada con exito")
                window.location = $scope.config.WebIp + "/PaginaWeb/verSolicitudesEst.html"
            }, function errorCallback(response) {
                alert("Ha ocurrido un erro intentelo mas tarde");
            });
    }
});