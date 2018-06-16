// /APILogin/ce/Users

var myApp = angular.module('Reportes', []);

myApp.controller('ReportesInicialCtrl', function ($scope, $http) {

    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url1 = $scope.config.MyApi;


            



            $http.get(url1 + "api/Varios/GetTiposBeca")
                .then(function (res) {
                    console.log(res.data);
                    $scope.tiposbeca = res.data;
                    
                });


            $scope.actualizar = function () {

                $http.get(url1 + "api/Reporte/GetReporteInicial?anno=" + $scope.ano + "&beca=" + $scope.tb + "&periodo=" + $scope.periodo)
                    .then(function (res) {
                        console.log(res.data);
                        $scope.reportes = res.data;

                    });



            }

        });

});

myApp.controller('ReportesFinalCtrl', function ($scope, $http) {

    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url1 = $scope.config.MyApi;






            $http.get(url1 + "api/Varios/GetTiposBeca")
                .then(function (res) {
                    console.log(res.data);
                    $scope.tiposbeca = res.data;

                });

            http://localhost:64698/api/Reporte/GetReporteFinal?anno=2018&beca=1&periodo=II
            $scope.actualizar = function () {

                console.log($scope.ano, $scope.tb, $scope.periodo);

                if ($scope.ano != null && $scope.tb != null && $scope.periodo != null){
                    $http.get(url1 + "api/Reporte/GetReporteFinal?anno=" + $scope.ano + "&beca=" + $scope.tb + "&periodo=" + $scope.periodo)
                        .then(function (res) {
                            console.log(res.data);
                            $scope.reportes = res.data;

                        });
                } else {
                    console.log("Falta de completar");
                }
                



            }

        });

});