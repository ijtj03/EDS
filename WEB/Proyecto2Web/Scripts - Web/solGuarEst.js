

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
                    const uGL = $scope.config.MyApi + "api/Parametros/GetLast";
                    $http.get(uGL)
                        .then(function (res) {
                            $scope.param = res.data;
                            var dia = $scope.param.FechaFinalSol.substring(0, 2);
                            var mes = $scope.param.FechaFinalSol.substring(3, 5);
                            var anho = $scope.param.FechaFinalSol.substring(6, 10);
                            console.log("FechaParam", dia, mes,anho);
                        });
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
        var date = new Date();
        var month = date.getMonth();
        if (month > 6) {
            p = "II";
        } else {
            p = "I";
        }
        const url = $scope.config.MyApi + "api/Formularios/EnviarForm?IdFormulario=" + idForm + "&Periodo=" + p + "&IdCarnet=" + window.localStorage.getItem("idCarnet");
        $http.get(url)
            .then(function successCallback(response) {
                alert("Su solicitud se ha realizado correctamente");
            }, function errorCallback(response) {
                alert("Ha ocurrido un erro intentelo mas tarde");

                console.log(ip);
                console.log(body);
            });
    }
});