var mA = angular.module('HomeAdm', []);

mA.controller('HomeAdmCtrl', function ($scope, $http) {
    if (window.localStorage.getItem("IdUser") != null) {
        $scope.config;
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;

                //window.localStorage.setItem("IdUser", 2);//ESTO JAMAS VA AQUI<ES POR NO TENER LOGIN AUN>
                const ip = "http://" + $scope.config.ApiIp + "/APILogin/ce/Users/" + window.localStorage.getItem("IdUser");
                $http.get(ip)
                    .then(function (res) {
                        $scope.admin = res.data;
                    });

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