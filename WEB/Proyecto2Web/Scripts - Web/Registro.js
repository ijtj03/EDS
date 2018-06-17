﻿var myApp = angular.module('Registro', []);

myApp.controller('RegistroCtrl', function ($scope, $http) {

    if (window.localStorage.getItem("IdUser") != null) {
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const url1 = $scope.config.MyApi;

                $http.get(url1 + "api/Varios/GetRoles")
                    .then(function (res) {
                        console.log(res.data);
                        $scope.roles = res.data;
                    });

                $scope.form = function () {
                    const url2 = "http://" + $scope.config.ApiIp + "/APILogin/ce/Users";

                    var consulta = {

                        "correo_electronico": $scope.Correo,
                        "contrasenna": null,
                        "primer_nombre": $scope.Nombre,
                        "segundo_nombre": "",
                        "primer_apellido": $scope.Apellido1,
                        "segundo_apellido": $scope.Apellido2,
                        "role": $scope.sel,
                        "id": 8,
                        "cedula": $scope.Cedula

                    };

                    $http.post(url2, consulta)
                        .then(function successCallback(response) {

                            alert("Se creo el usuario correctamente");
                            const loc = $scope.config.WebIp + "/PaginaWeb/homeAdm.html";
                            window.location = loc;
                            console.log(response.data);


                        }, function errorCallback(response) {
                            console.log(consulta);
                            alert("Ha ocurrido un error, intentelo mas tarde");
                        });

                }
            });

    } else {
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const loc = $scope.config.WebIp + "/PaginaWeb/logUsers.html";
                alert("Debe iniciar sesion");
                window.location = loc;
            });
    }
    
});