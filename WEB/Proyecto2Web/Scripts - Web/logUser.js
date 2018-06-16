var mA = angular.module('LogUser', []);

mA.controller('LogUserCtrl', function ($scope, $http) {
    $scope.config;
    $scope.carnet;
    $scope.email;
    $scope.password;
    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
        });
    $scope.sel = function () {
        console.log($scope.selRol);
        if ($scope.selRol==2) {
            window.localStorage.setItem("userLoc", "homeAdm.html");
            console.log(window.localStorage.getItem("userLoc"));
        }
        if ($scope.selRol == 3) {
            window.localStorage.setItem("userLoc", "homeEnc.html");
            console.log(window.localStorage.getItem("userLoc"));
        }
        if ($scope.selRol == 4) {
            window.localStorage.setItem("userLoc", "homeCom.html");
            console.log(window.localStorage.getItem("userLoc"));
        }
            
        if ($scope.user.first_time) {
            document.getElementById("info1").hidden = true;
            document.getElementById("info2").hidden = true;
            document.getElementById("varios").hidden = true;
            document.getElementById("newpass").hidden = false;
        } else {
            window.location = loc + window.localStorage.getItem("userLoc");
        }
    }
    $scope.cPass = function () {
        if ($scope.nP == $scope.nP1 && $scope.nP1 != null) {
            const loc = $scope.config.WebIp + "/PaginaWeb/";
            const url4 = "http://" + $scope.config.ApiIp + "/APILogin/ce/Users/" + window.localStorage.getItem("idUser");
            body = {
                correo_electronico: $scope.user.usuario.correo_electronico,
                contrasenna: btoa($scope.nP),
                primer_nombre: $scope.user.usuario.primer_nombre,
                segundo_nombre: $scope.user.usuario.segundo_nombre,
                primer_apellido: $scope.user.usuario.primer_apellido,
                segundo_apellido: $scope.user.usuario.segundo_apellido,
                role: $scope.user.usuario.rols[0].id_rol,
                id: 8,
                cedula: $scope.user.usuario.cedula
            };

            console.log(body);
            $http.put(url4, body)
                .then(function successCallback(response) {
                    window.location = loc + window.localStorage.getItem("userLoc");
                }, function errorCallback(response) {
                    alert("Hubo un error, intentelo mas tarde");
                    window.location = loc + window.localStorage.getItem("userLoc");
                });
        } else {
            alert("Las contraseñas no coinciden");
        }
        
    }
    $scope.doLogin = function () {
        const loc = $scope.config.WebIp + "/PaginaWeb/";
        const ip = "http://" + $scope.config.ApiIp + "/APILogin/ce/UserAuth/Authenticate";
        body = {
            "correo_electronico": $scope.email,
            "password": btoa($scope.password)
        };
        $http.post(ip, body)
            .then(function successCallback(response) {
                $scope.user = response.data;
                window.localStorage.setItem("idUser", $scope.user.usuario.id);
                if ($scope.user.usuario.rols.length > 1) {
                    document.getElementById("varios").hidden = false;
                    document.getElementById("info1").hidden = true;
                    document.getElementById("info2").hidden = true;
                } else {
                    switch ($scope.user.usuario.rols[0].id_rol) {
                        case 2:
                            window.localStorage.setItem("userLoc", "homeAdm.html");
                            break;
                        case 3:
                            window.localStorage.setItem("userLoc", "homeEnc.html");
                            break;
                        case 4:
                            window.localStorage.setItem("userLoc", "homeCom.html");
                            break;
                        default:
                            alert("Su usuario no posee roles para este sistema");
                            return;
                    }
                    if ($scope.user.first_time) {
                        document.getElementById("info1").hidden = true;
                        document.getElementById("info2").hidden = true;
                        document.getElementById("varios").hidden = true;
                        document.getElementById("newpass").hidden = false;
                    } else {
                        window.location = loc + window.localStorage.getItem("userLoc");
                    }
                }
            }, function errorCallback(response) {
                alert("Los datos ingresados no coinsiden");
            });
    }
});