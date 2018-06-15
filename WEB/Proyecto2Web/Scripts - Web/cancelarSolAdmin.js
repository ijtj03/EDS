var myApp = angular.module('cancelarSolAdmin', []);

myApp.controller('cancelarSolAdminCtrl', function ($scope, $http) {

    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url1 = $scope.config.MyApi;


            $http.get(url1 + "api/Solicitud/GetAllCancelaciones?Estado=6")
                .then(function (res) {
                    $scope.solicitudes = res.data;
                    console.log(res.data);



                });

            $scope.modal = function (x) {
                $scope.estudiante = x;
                console.log($scope.estudiante);


            }

            $scope.cancelar = function (x) {
                var Id = x.IdSolicitud;
                const url2 = url1 + "api/Solicitud/CancelarSolicitudUsuario?IdSolicitud=" + Id;
                
                $http.post(url2)
                    .then(function successCallback(response) {

                        alert("Se cancelo correctamente la solicitud");
                        const loc = $scope.config.WebIp + "/PaginaWeb/cancelacionAdm.html";
                        window.location = loc;

                    }, function errorCallback(response) {
                        console.log(consulta);
                        alert("Ha ocurrido un error, intentelo mas tarde");
                    });
            }

           
        });
});