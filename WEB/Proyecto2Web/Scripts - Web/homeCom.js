var mA = angular.module('HomeCom', []);

mA.controller('HomeComCtrl', function ($scope, $http) {
    if (window.localStorage.getItem("IdUser") == null) {
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const url1 = $scope.config.MyApi + "api/Solicitud/GetSolComision";
                $http.get(url1)
                    .then(function (res) {
                        $scope.sols = res.data;
                    });
            });
    } else {
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const loc = $scope.config.WebIp + "/PaginaWeb/logUsers.html";
                alert("Debe iniciar sesion");
                window.location = loc;
            });
    }
    /*$scope.config;
    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            $scope.nC = window.localStorage.getItem("pN") + " " + window.localStorage.getItem("pA") + " " + window.localStorage.getItem("sA");
            $scope.tB = window.localStorage.getItem("tB");
            $scope.hB = window.localStorage.getItem("hB");
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
    $scope.calificar = function (idEv,pN,pA,sA,tB,hB) {
        const loc = $scope.config.WebIp + "/PaginaWeb/calificarEnc.html";
        window.localStorage.setItem("idEv", idEv);
        window.localStorage.setItem("pN", pN);
        window.localStorage.setItem("pA", pA);
        window.localStorage.setItem("sA", sA);
        window.localStorage.setItem("tB", tB);
        window.localStorage.setItem("hB", hB);
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
    }*/
});