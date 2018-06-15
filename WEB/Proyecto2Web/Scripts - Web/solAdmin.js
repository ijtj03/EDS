var myApp = angular.module('solAdmin', []);

myApp.controller('solAdminCtrl', function ($scope, $http) {
    
    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url1 = $scope.config.MyApi;

            if ($scope.r == 1) { // Esto es para HE 
                $http.get(url1 + "api/Solicitud/GetSolicitudesRevision?TipoBeca=" + "1")
                    .then(function (res) {
                        $scope.sol = res.data;
                        console.log(res.data);

                    });
            } else if ($scope.r == 2) { // Esto es para HA
                $http.get(url1 + "api/Solicitud/GetSolicitudesRevision?TipoBeca=" + "2")
                    .then(function (res) {
                        $scope.sol = res.data;
                        console.log(res.data);

                    });
            } else if ($scope.r == 3) { // Esto es para TE
                $http.get(url1 + "api/Solicitud/GetSolicitudesRevision?TipoBeca=" + "3")
                    .then(function (res) {
                        $scope.sol = res.data;
                        console.log(res.data);

                    });
            } else if ($scope.r == 4) { // Esto es para AE
                $http.get(url1 + "api/Solicitud/GetSolicitudesRevision?TipoBeca=" + "4")
                    .then(function (res) {
                        $scope.sol = res.data;
                        console.log(res.data);

                    });
            }
            


        

            $scope.modal = function (x) {
                $scope.estudiante = x;
                console.log($scope.estudiante);


            }   

            $scope.cumple = function (IdSolicitud) {
                console.log(IdSolicitud);
                window.localStorage.setItem("IdUsuario", 2015012410);
                //window.localStorage.getItem("IdUsuario");
                const url2 = url1 + "api/Solicitud/AceptarSolicitudUsuario?IdSolicitud=" + IdSolicitud + "&IdUsuario=" + window.localStorage.getItem("IdUsuario");
                
               /* $http.post(url2)
                    .then(function successCallback(response) {
                        alert("Se acepto el cumplimiento de requisitos");
                        console.log(consulta);
                        $scope.textbox = null;
                        window.location.href = '#close';
                    }, function errorCallback(response) {
                        console.log(consulta);
                        $scope.textbox = null;
                        alert("Ha ocurrido un error, intentelo mas tarde");
                    });*/
   
            }

            $scope.nocumple = function (x ) {

                console.log(x);

                if (x != null){
                    window.location.href = '#close';
                    $scope.textbox = null;
                } else {
                    alert("No se ha llenado la descripcion");
                }
            }
    });
    




});