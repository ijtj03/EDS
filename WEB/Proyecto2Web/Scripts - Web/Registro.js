// /APILogin/ce/Users

var myApp = angular.module('Requisitos', []);

myApp.controller('RequisitosCtrl', function ($scope, $http) {

    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url1 = $scope.config.MyApi;


            // /APILogin/ce/Users

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

});