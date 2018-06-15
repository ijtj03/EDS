var myApp = angular.module('Requisitos', []);

myApp.controller('RequisitosCtrl', function ($scope, $http) {

    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url1 = $scope.config.MyApi;


            if ($scope.r == 1){
                console.log("Estoy en Cumple Requisitos");
                $http.get(url1 + "api/Solicitud/GetAllAprobadasRechazadas?Estado=4")
                    .then(function (res) {
                        $scope.sol = res.data;
                        console.log(res.data);

                    });
            } else if ($scope.r == 2) {
                console.log("Estoy en No Cumple Requisitos");
                $http.get(url1 + "api/Solicitud/GetAllAprobadasRechazadas?Estado=5" )
                    .then(function (res) {
                        $scope.sol = res.data;
                        console.log(res.data);

                    });
            }

            $scope.modal = function (x) {
                $scope.estudiante = x;
                console.log($scope.estudiante);


            }

        });





});