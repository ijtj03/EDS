var mA = angular.module('HomeEnc', []);

mA.controller('HomeEncCtrl', function ($scope, $http) {
    $scope.config;
    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            window.localStorage.setItem("IdUser", 2);//ESTO JAMAS VA AQUI<ES POR NO TENER LOGIN AUN>
            const ip = "http://" + $scope.config.ApiIp + "/APILogin/ce/Users/" + window.localStorage.getItem("IdUser");
            $http.get(ip)
                .then(function (res) {
                    $scope.user = res.data;
                });
            const url1 = $scope.config.MyApi + "api/Evaluar/GetEstudiantesxEvaluar?encargado=" + window.localStorage.getItem("IdUser");
            $http.get(url1)
                .then(function (res) {
                    $scope.evs = res.data;
                });
        });
    $scope.calificar = function (idEv) {
        const loc = $scope.config.WebIp + "/PaginaWeb/calificarEnc.html";
        window.localStorage.setItem("idEv", idEv);
        window.location = loc;
    }
    $scope.cal = function () {
        const loc = $scope.config.WebIp + "/PaginaWeb/homeEnc.html";
        const url9 = $scope.config.MyApi + "api/Evaluar/EvaluarEstudiante";
        if ($scope.rec) {
            var c = {
                IdEvaluacion: window.localStorage.getItem("idEv"),
                Recomienda: 1,
                HorasLaboradas: $scope.hl,
                Observaciones: $scope.obs
            };
            $http.post(url9, c)
                .then(function successCallback(response) {
                    alert("La revision se ha enviado con exito");
                    window.location = loc;
                }, function errorCallback(response) {
                    alert("Ha ocurrido un error por favor intentelo mas tarde");
                    window.location = loc;
                });
        } else {
            var c = {
                IdEvaluacion: window.localStorage.getItem("idEv"),
                Recomienda: 0,
                HorasLaboradas: $scope.hl,
                Observaciones: $scope.obs
            };
            $http.post(url9, c)
                .then(function successCallback(response) {
                    alert("Su clave ha sido enviada al correo");
                    window.location = loc;
                }, function errorCallback(response) {
                    alert("Ha ocurrido un error por favor intentelo mas tarde");
                    window.location = loc;
                });
        }
        //window.location = loc;
    }
});