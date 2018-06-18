

var mA = angular.module('SolGuarEst', []);

mA.controller('SolGuarEstCtrl', function ($scope, $http) {
    $scope.config;
    $scope.forms;
    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            $scope.config = res.data;
            const url = $scope.config.MyApi + "api/Formularios/GetFormulariosGuardados?estudiante=" + window.localStorage.getItem("idCarnet");
            console.log(url);
            $http.get(url)
                .then(function (res) {
                    $scope.forms = res.data;
                });
        });
    $scope.eliminarForm = function (idForm) {
        const url = $scope.config.MyApi + "api/Formularios/EliFormGuardado?idForm=" + idForm;
        $http.post(url)
            .then(function successCallback(response) {
                alert("Su formulario se ha eliminado");
                window.location = $scope.config.WebIp + "/PaginaWeb/solicitudesGuarEst.html"
            }, function errorCallback(response) {
                alert("Ha ocurrido un erro intentelo mas tarde");
            });
    }
    $scope.enviarForm = function (idForm) {
        var p;
        const uGL = $scope.config.MyApi + "api/Parametros/GetLast";
        var date = new Date();
        var day = date.getDay();
        var month = date.getMonth() + 1;
        var year = date.getFullYear();
        if (month > 6) {
            p = "II";
        } else {
            p = "I";
        }
        $http.get(uGL)
            .then(function (res) {
                $scope.param = res.data;
                var pos1 = $scope.param.FechaFinalSol.indexOf("/");
                var pos2 = $scope.param.FechaFinalSol.lastIndexOf("/");
                var dia = parseInt($scope.param.FechaFinalSol.substring(0, pos1));
                var mes = parseInt($scope.param.FechaFinalSol.substring(pos1+1, pos2));
                var anho = parseInt($scope.param.FechaFinalSol.substring(pos2 + 1, pos2 + 5));
                console.log(year, month, day);
                console.log(anho, mes, dia);
                if (year < anho || (year == anho && month < mes) || (year == anho && month == mes && day < dia)) {
                    const url = $scope.config.MyApi + "api/Formularios/EnviarForm?IdFormulario=" + idForm + "&Periodo=" + p + "&IdCarnet=" + window.localStorage.getItem("idCarnet");
                    $http.get(url)
                        .then(function successCallback(response) {
                            alert("Su solicitud se ha realizado correctamente");
                        }, function errorCallback(response) {
                            alert("Ha ocurrido un erro intentelo mas tarde");

                            console.log(ip);
                            console.log(body);
                        });
                } else {
                    alert("Esta fuera de fecha, envielo despues")
                }
            });
    }
});