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
        const loc = $scope.config.WebIp + "/PaginaWeb/homeEst.html";
        window.localStorage.setItem("idCarnet", $scope.carnet);
        window.location = loc;
    }
    $scope.doToken = function () {
        const ip = "http://" + $scope.config.ApiIp + "/APILogin/ce/StudentAuth/Token/";
        body = {
            "carne": $scope.carnet,
            "email": $scope.email
        };
        if ($scope.carnet != null && $scope.email != null) {
            $http({
                url: ip,
                dataType: "json",
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                }
            })
                .then(function successCallback(response) {
                    alert("Su clave ha sido enviada al correo");
                    console.log(response.data.Message);
                }, function errorCallback(response) {
                    alert("El carnet no coincide con el correo escrito");
                    
                    console.log(ip);
                    console.log(body);
                });
        } else {
            alert("Debe tener el campo carnet y correo instititucional llenos");
        }
    }
});