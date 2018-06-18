var myApp = angular.module('Parametros', []);

myApp.controller('ParametrosCtrl', function ($scope, $http) {

    if (window.localStorage.getItem("IdUser") != null){
        $http.get('../Scripts - Web/config.json')
            .then(function (res) {
                $scope.config = res.data;
                const url1 = $scope.config.MyApi;


                $http.get(url1 + "api/Parametros/GetLast")
                    .then(function (res) {
                        $scope.sol = res.data;
                        console.log(res.data);

                        var param = res.data;



                        /*$scope.fetb = param.FechaAjuste;
                        $scope.fas = param.FechaInicialSol;
                        $scope.fcs = param.FechaFinalSol;
                        $scope.fae = param.FechaInicialCal;
                        $scope.fce = param.FechaFinalCal;*/
                        $scope.hae = param.HorasBecaAsEsp;
                        $scope.ha = param.HorasBecaAsis;
                        $scope.nmhb = param.HorasBecaTotales;
                        $scope.ht = param.HorasBecaTutoria;
                        $scope.he = param.HorasBecaEstudiante;

                    });



                $scope.form = function () {
                    var consulta =
                        {
                            "FechaAjuste": $scope.fetb,
                            "FechaInicialSol": $scope.fas,
                            "FechaFinalSol": $scope.fcs,
                            "FechaInicialCal": $scope.fae,
                            "FechaFinalCal": $scope.fce,
                            "HorasBecaAsEsp": $scope.hae,
                            "HorasBecaAsis": $scope.ha,
                            "HorasBecaTotales": $scope.nmhb,
                            "HorasBecaTutoria": $scope.ht,
                            "HorasBecaEstudiante": $scope.he

                        }
                    console.log(consulta);
                    const url3 = url1 + "api/Parametros/GuardarParametros";
                    $http.post(url3, consulta)
                        .then(function successCallback(response) {

                            alert("Se guardaron correctamente los parametros");
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