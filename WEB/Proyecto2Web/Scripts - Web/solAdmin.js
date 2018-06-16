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

            $scope.borrar = function () {
                console.log($scope.textbox);
                if ($scope.r == 1) {
                    $scope.textbox = "";
                    const loc = $scope.config.WebIp + "/PaginaWeb/SolHEAdm.html";
                    window.location = loc;
                    console.log(response.data);
                    console.log($scope.textbox);
                } else if ($scope.r == 2) {
                    $scope.textbox = "";
                    const loc = $scope.config.WebIp + "/PaginaWeb/SolHAAdm.html";
                    window.location = loc;
                    console.log(response.data);
                    
                } else if ($scope.r == 3) {
                    $scope.textbox = "";
                    const loc = $scope.config.WebIp + "/PaginaWeb/SolTEAdm.html";
                    window.location = loc;
                    console.log(response.data);
                    
                } else if ($scope.r == 4) {
                    $scope.textbox = "";
                    const loc = $scope.config.WebIp + "/PaginaWeb/SolAEAdm.html";
                    window.location = loc;
                    console.log(response.data);
                    
                }
            }

            $scope.cumple = function (IdSolicitud) {
                console.log(IdSolicitud);
                window.localStorage.setItem("IdUser", 1);
                //window.localStorage.getItem("IdUsuario");
                const url2 = url1 + "api/Solicitud/EstadoCumple";

                if ($scope.textbox == null) {
                    var consulta =
                        {
                            "IdSolicitud": IdSolicitud,
                            "Descripcion": ""
                        };
                } else {
                    var consulta =
                        {
                            "IdSolicitud": IdSolicitud,
                            "Descripcion": $scope.textbox
                        };
                }
                



                $http.post(url2, consulta)
                   .then(function successCallback(response) {


                       

                       alert("Se acepto el cumplimiento de requisitos");
                       if ($scope.r == 1) {
                           const loc = $scope.config.WebIp + "/PaginaWeb/SolHEAdm.html";
                           window.location = loc;
                           console.log(response.data);
                           $scope.textbox = null;
                       } else if ($scope.r == 2) {
                           const loc = $scope.config.WebIp + "/PaginaWeb/SolHAAdm.html";
                           window.location = loc;
                           console.log(response.data);
                           $scope.textbox = null;
                       } else if ($scope.r == 3) {
                           const loc = $scope.config.WebIp + "/PaginaWeb/SolTEAdm.html";
                           window.location = loc;
                           console.log(response.data);
                           $scope.textbox = null;
                       } else if ($scope.r == 4) {
                           const loc = $scope.config.WebIp + "/PaginaWeb/SolAEAdm.html";
                           window.location = loc;
                           console.log(response.data);
                           $scope.textbox = null;
                       }
                       
                    }, function errorCallback(response) {
                        console.log(consulta);
                        $scope.textbox = null;
                        alert("Ha ocurrido un error, intentelo mas tarde");
                    });
   
            }

            $scope.nocumple = function (x, IdSolicitud) {

                console.log(x);

                const url3 = url1 + "api/Solicitud/EstadoNoCumple";
                if (x != null) {
                    var consulta =
                        {
                            "IdSolicitud": IdSolicitud,
                            "Descripcion": x
                        };
                    $http.post(url3, consulta)
                        .then(function successCallback(response) {
                            
                            alert("Se realizo correctamente la solicitud");
                            if ($scope.r == 1) {
                                const loc = $scope.config.WebIp + "/PaginaWeb/SolHEAdm.html";
                                window.location = loc;
                                console.log(response.data);
                                $scope.textbox = null;
                            } else if ($scope.r == 2){
                                const loc = $scope.config.WebIp + "/PaginaWeb/SolHAAdm.html";
                                window.location = loc;
                                console.log(response.data);
                                $scope.textbox = null;
                            } else if ($scope.r == 3){
                                const loc = $scope.config.WebIp + "/PaginaWeb/SolTEAdm.html";
                                window.location = loc;
                                console.log(response.data);
                                $scope.textbox = null;
                            } else if ($scope.r == 4){
                                const loc = $scope.config.WebIp + "/PaginaWeb/SolAEAdm.html";
                                window.location = loc;
                                console.log(response.data);
                                $scope.textbox = null;
                            }
                            
                        }, function errorCallback(response) {
                            console.log(consulta);
                            alert("Ha ocurrido un error, intentelo mas tarde");
                        });
                    
                } else {
                    alert("No se ha llenado la descripcion");
                }
            }
    });
    




});