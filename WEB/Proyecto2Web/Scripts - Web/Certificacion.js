// /APILogin/ce/Users

var myApp = angular.module('Certificacion', []);

myApp.controller('CertificacionEstudianteCtrl', function ($scope, $http) {

    if (window.localStorage.getItem("IdUser") == null) {
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const url1 = $scope.config.MyApi;


                if ($scope.ano == null && $scope.tb == null && $scope.periodo == null) {
                    document.getElementById("tabla").hidden = true;
                }



                $http.get(url1 + "api/Varios/GetTiposBeca")
                    .then(function (res) {
                        console.log(res.data);
                        $scope.tiposbeca = res.data;

                    });



                $scope.actualizar = function () {

                    console.log($scope.ano, $scope.tb, $scope.periodo);

                    if ($scope.ano != null && $scope.tb != null && $scope.periodo != null) {

                        $http.get(url1 + "api/Reporte/GetReporteInicial?anno=" + $scope.ano + "&beca=" + $scope.tb + "&periodo=" + $scope.periodo)
                            .then(function (res) {
                                console.log(res.data);
                                $scope.reportes = res.data;

                                if ($scope.reportes.length == 0) {
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


                if ($scope.ano == null && $scope.tb == null && $scope.periodo == null) {
                    document.getElementById("tabla").hidden = true;
                }



                $http.get(url1 + "api/Varios/GetTiposBeca")
                    .then(function (res) {
                        console.log(res.data);
                        $scope.tiposbeca = res.data;

                    });



                $scope.actualizar = function () {

                    console.log($scope.ano, $scope.tb, $scope.periodo);

                    if ($scope.ano != null && $scope.tb != null && $scope.periodo != null) {

                        $http.get(url1 + "api/Reporte/GetReporteFinal?anno=" + $scope.ano + "&beca=" + $scope.tb + "&periodo=" + $scope.periodo)
                            .then(function (res) {
                                console.log(res.data);
                                $scope.reportes = res.data;

                                if ($scope.reportes.length == 0) {
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