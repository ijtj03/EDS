// /APILogin/ce/Users

var myApp = angular.module('Certificacion', []);

myApp.controller('CertificacionEstudianteCtrl', function ($scope, $http) {

    if (window.localStorage.getItem("IdUser") == null) {
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const url1 = $scope.config.MyApi;


                if ($scope.carne == null ) {
                    document.getElementById("tabla").hidden = true;
                }



                /*$http.get(url1 + "api/Varios/GetTiposBeca")
                    .then(function (res) {
                        console.log(res.data);
                        $scope.tiposbeca = res.data;

                    });
                */


                $scope.actualizar = function () {

                    console.log($scope.carne);

                    if ($scope.carne != null || $scope.carne != "") {

                        $http.get(url1 + "api/Reporte/GetHistoricoEstudiante?carnet=" + $scope.carne)
                            .then(function (res) {
                                console.log(res.data);
                                $scope.certificaciones = res.data;

                                if ($scope.certificaciones.length == 0) {
                                    document.getElementById("tabla").hidden = true;
                                } else {
                                    document.getElementById("tabla").hidden = false;
                                }

                            });
                    } else {
                        document.getElementById("tabla").hidden = true;
                    }




                }

            });
    } else {
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const loc = $scope.config.WebIp + "/PaginaWeb/index.html";
                alert("Debe iniciar sesion");
                window.location = loc;
            });
    }



});

myApp.controller('HistoricosProfesorCtrl', function ($scope, $http) {

    //console.log(window.localStorage.getItem("IdUser"));
    if (window.localStorage.getItem("IdUser") == null) {
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const url1 = $scope.config.MyApi;


                if ($scope.cedula == null) {
                    document.getElementById("tabla").hidden = true;
                }



                $scope.actualizar = function () {

                    console.log($scope.cedula);

                    if ($scope.cedula != null || $scope.cedula != "") {
                        
                        $http.get(url1 + "api/Reporte/GetHistoricoProfesor?cedula=" + $scope.cedula )
                            .then(function (res) {
                                console.log(res.data);
                                $scope.historicos = res.data;
                                console.log($scope.historicos);

                                if ($scope.historicos.length == 0) {
                                    document.getElementById("tabla").hidden = true;
                                } else {
                                    document.getElementById("tabla").hidden = false;
                                }

                            });
                    } else {
                        document.getElementById("tabla").hidden = true;
                    }




                }

            });
    } else {
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const loc = $scope.config.WebIp + "/PaginaWeb/index.html";
                alert("Debe iniciar sesion");
                window.location = loc;
            });
    }


});