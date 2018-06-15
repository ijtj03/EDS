var myApp = angular.module('cancelarSolAdmin', []);

myApp.controller('cancelarSolAdmninCtrl', function ($scope, $http) {

    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url1 = $scope.config.MyApi;


            $http.get(url1 + "api/Solicitud/GetAllCancelaciones?Estado=6")
                .then(function (res) {
                    $scope.sol = res.data;
                    console.log(res.data);

                });





            $scope.modal = function (x) {
                $scope.estudiante = x;
                console.log($scope.estudiante);


            }

           
        });
});