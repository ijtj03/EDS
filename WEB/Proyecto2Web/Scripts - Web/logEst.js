var mA = angular.module('LogEst', []);

mA.controller('LogEstCtrl', function ($scope, $http) {
    $scope.config;
    $scope.carnet;
    $scope.email;
    $scope.password;
    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
        });
    $scope.doLogin = function () {
        const ip = "http://" + $scope.config.ApiIp;
    }
    $scope.doToken = function () {
        const ip = "http://" + $scope.config.ApiIp;
        body = {
            "carne": $scope.carnet,
            "email": $scope.email
        };
        hs= {
            "Accept": "text / json",
            "Content - Type": "application/json"
        };
        
        if ($scope.carnet != null && $scope.email != null) {
           // $http.get(ip + "/CE-Authentication-API/ce/StudentAuth/Token/", body)
            $http({
                method: "GET",
                url: ip + "/CE-Authentication-API/ce/StudentAuth/Token/",
                params: {
                    "email": $scope.email,
                    "carne": $scope.carnet
                }
            })
                .then(function successCallback(response) {
                    alert("Su clave ha sido enviada al correo");
                    console.log(response.data.Message,"Hola mundo");
                }, function errorCallback(response) {
                    alert("El carnet no coincide con el correo escrito");
                    console.log(ip);
                });
        } else {
            alert("Debe tener el campo carnet y correo instititucional llenos");
        }
    }
});