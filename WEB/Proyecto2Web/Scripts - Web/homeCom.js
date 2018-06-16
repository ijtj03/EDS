var mA = angular.module('HomeCom', []);

mA.controller('HomeComCtrl', function ($scope, $http) {
    if (window.localStorage.getItem("IdUser") != null) {
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const url1 = $scope.config.MyApi + "api/Solicitud/GetSolComision";
                $http.get(url1)
                    .then(function (res) {
                        $scope.sols = res.data;
                    });

                const url2 = $scope.config.MyApi + "api/Varios/GetAllEnc";
                $http.get(url2)
                    .then(function (res) {
                        $scope.users = res.data;
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
    $scope.revisando = function (idSol) {
        $scope.idRevisando = idSol;
    }
    $scope.aceptar = function () {
        if ($scope.usuario != null && $scope.usuario > 0) {
            const url = $scope.config.MyApi + "api/Solicitud/AceptarSolicitudUsuario?IdSolicitud=" + $scope.idRevisando + "&IdUsuario=" + $scope.usuario + "&hAs=" + $scope.hAs;
           const loc = $scope.config.WebIp + "/PaginaWeb/homeCom.html";
            console.log(url);
            $http.post(url)
                .then(function successCallback(response) {
                    alert("Se ha aceptado la beca");
                    window.location = loc;
                }, function errorCallback(response) {
                    alert("Ha ocurrido un error,  intentelo mas tarde");
                    window.location = loc;
                });
        } else {
            alert("Debe seleccionar el encargado");
        }
        
    }
    
    $scope.rechazar = function (id) {
        const url = $scope.config.MyApi + "api/Solicitud/RechazarSolicitud?idSolicitud=" +id;
        const loc = $scope.config.WebIp + "/PaginaWeb/homeCom.html";
        console.log(url);
        $http.post(url)
            .then(function successCallback(response) {
                alert("Se ha recazado la beca");
                window.location = loc;
            }, function errorCallback(response) {
                alert("Ha ocurrido un error,  intentelo mas tarde");
                window.location = loc;
            });
       

    }
});