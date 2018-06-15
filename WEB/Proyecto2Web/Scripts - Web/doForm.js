var mA = angular.module('DoForm', []);

mA.controller('DoFormCtrl', function ($scope, $http) {
    var date = new Date();
    console.log(date.getDate());
    $scope.boton = function () {
        if ($scope.s) {
            document.getElementById("studentHours").disabled = false;
            document.getElementById("scholarshipId").disabled = false;
            document.getElementById("department").disabled = false;
            document.getElementById("studentHours").required = true;
            document.getElementById("scholarshipId").required = true;
            document.getElementById("department").required = true;
            
            
        } else {
            document.getElementById("studentHours").disabled = true;
            document.getElementById("scholarshipId").disabled = true;
            document.getElementById("department").disabled = true;
        }
    }

    $http.get('../Scripts - Web/config.json')
       .then(function(res){
           $scope.config = res.data;
           $scope.carga = 0;
           const url1 = $scope.config.MyApi + "api/Varios/GetAllDeps";
           $http.get(url1)
               .then(function (res) {
                   $scope.deps = res.data;
                   $scope.boton();
               });
           const url2 = $scope.config.MyApi + "api/Varios/GetAllCursos";
           $http.get(url2)
               .then(function (res) {
                   $scope.cursos = res.data;
               });
           $scope.cImg = function (id) {

               if (id == 1 || id == 4) {
                   $scope.idCurso = 1;
               }
               $scope.IdBeca = id;
               var imgPPA = document.getElementById('imgPPA').files[0];
               var reader = new FileReader();
               reader.onloadend = function () {
                   $scope.iPPA = reader.result;
               }; reader.readAsDataURL(imgPPA);

               var imgPPG = document.getElementById('imgPPG').files[0];
               var reader1 = new FileReader();
               reader1.onloadend = function () {
                   $scope.iPPG = reader1.result;
               }; reader1.readAsDataURL(imgPPG);

               var imgCuenta = document.getElementById('imgCuenta').files[0];
               var reader2 = new FileReader();
               reader2.onloadend = function () {
                   $scope.iCuenta = reader2.result;
               }; reader2.readAsDataURL(imgCuenta);

               var imgCed = document.getElementById('imgCed').files[0];
               var reader3 = new FileReader();
               reader3.onloadend = function () {
                   $scope.iCed = reader3.result;
               }; reader3.readAsDataURL(imgCed);
               $scope.carga = 1;
               
               alert("Se cargaron las imagenes seleccionadas");
           }
           $scope.form = function () {
               if ($scope.carga == 1) {
                   if ($scope.sub == 1) {
                       const url3 = $scope.config.MyApi + "api/Formularios/GuardarForm";
                       if ($scope.s) {
                           var consulta = {
                               Carnet: window.localStorage.getItem("idCarnet"),
                               IdCurso: $scope.idCurso,
                               IdForm: 0,
                               IdDep: $scope.idDep,
                               IdBeca: $scope.IdBeca,
                               Tel: $scope.tel,
                               Correo: $scope.email,
                               PromedioCurso: $scope.pc,
                               PromedioPonderadoAnterior: $scope.ppa,
                               PromedioPonderadoGen: $scope.ppg,
                               CuentaBancaria: $scope.cuentaBanc,
                               ImgCuentaBancaria: $scope.iCuenta,
                               ImgPromedioPonderadoAnterior: $scope.iPPA,
                               ImgPromedioPonderadoGeneral: $scope.iPPG,
                               ImgCedula: $scope.iCed,
                               OtraBeca: $scope.ob,
                               OtraBecaHoras: $scope.obh,
                               Cedula: $scope.ced,
                               TipoBeca: "HA"
                           };
                       } else {
                           var consulta = {
                               Carnet: window.localStorage.getItem("idCarnet"),
                               IdCurso: $scope.idCurso,
                               IdForm: 0,
                               IdDep: 1,
                               IdBeca: $scope.IdBeca,
                               Tel: $scope.tel,
                               Correo: $scope.email,
                               PromedioCurso: $scope.pc,
                               PromedioPonderadoAnterior: $scope.ppa,
                               PromedioPonderadoGen: $scope.ppg,
                               CuentaBancaria: $scope.cuentaBanc,
                               ImgCuentaBancaria: $scope.iCuenta,
                               ImgPromedioPonderadoAnterior: $scope.iPPA,
                               ImgPromedioPonderadoGeneral: $scope.iPPG,
                               ImgCedula: $scope.iCed,
                               OtraBeca: "",
                               OtraBecaHoras: -1,
                               Cedula: $scope.ced,
                               TipoBeca: "HA"
                           };
                       }
                       
                       $http.post(url3, consulta)
                           .then(function successCallback(response) {
                               alert("Guardado con exito");
                               console.log(consulta);
                               const loc = $scope.config.WebIp + "/PaginaWeb/homeEst.html";
                               window.location = loc
                           }, function errorCallback(response) {
                               console.log(consulta);
                               alert("Ha ocurrido un error, intentelo mas tarde");
                           });
                   }
                   else {
                       const uGL = $scope.config.MyApi + "api/Parametros/GetLast";
                       var date = new Date();
                       var day = date.getDay();
                       var month = date.getMonth() + 1;
                       var year = date.getFullYear();
                       $http.get(uGL)
                           .then(function (res) {
                               $scope.param = res.data;
                               $scope.param = res.data;
                               var pos1 = $scope.param.FechaFinalSol.indexOf("/");
                               var pos2 = $scope.param.FechaFinalSol.lastIndexOf("/");
                               var dia = parseInt($scope.param.FechaFinalSol.substring(0, pos1));
                               var mes = parseInt($scope.param.FechaFinalSol.substring(pos1 + 1, pos2));
                               var anho = parseInt($scope.param.FechaFinalSol.substring(pos2 + 1, pos2 + 5));
                               if (year < anho || (year == anho && month < mes) || (year == anho && month == mes && day < dia)) {
                                   const url3 = $scope.config.MyApi + "api/Formularios/GuardarEnviarForm";
                                   if (month > 6) {
                                       var p = "II";
                                   } else {
                                       var p = "I";
                                   }
                                   if ($scope.s) {
                                       var consulta = {
                                           Carnet: window.localStorage.getItem("idCarnet"),
                                           IdCurso: $scope.idCurso,
                                           IdForm: 0,
                                           IdDep: $scope.idDep,
                                           IdBeca: $scope.IdBeca,
                                           Tel: $scope.tel,
                                           Correo: $scope.email,
                                           PromedioCurso: $scope.pc,
                                           PromedioPonderadoAnterior: $scope.ppa,
                                           PromedioPonderadoGen: $scope.ppg,
                                           CuentaBancaria: $scope.cuentaBanc,
                                           ImgCuentaBancaria: $scope.iCuenta,
                                           ImgPromedioPonderadoAnterior: $scope.iPPA,
                                           ImgPromedioPonderadoGeneral: $scope.iPPG,
                                           ImgCedula: $scope.iCed,
                                           OtraBeca: $scope.ob,
                                           OtraBecaHoras: $scope.obh,
                                           Cedula: $scope.ced,
                                           TipoBeca: "HA",
                                           Periodo: p
                                       };
                                   } else {
                                       var consulta = {
                                           Carnet: window.localStorage.getItem("idCarnet"),
                                           IdCurso: $scope.idCurso,
                                           IdForm: 0,
                                           IdDep: 1,
                                           IdBeca: $scope.IdBeca,
                                           Tel: $scope.tel,
                                           Correo: $scope.email,
                                           PromedioCurso: $scope.pc,
                                           PromedioPonderadoAnterior: $scope.ppa,
                                           PromedioPonderadoGen: $scope.ppg,
                                           CuentaBancaria: $scope.cuentaBanc,
                                           ImgCuentaBancaria: $scope.iCuenta,
                                           ImgPromedioPonderadoAnterior: $scope.iPPA,
                                           ImgPromedioPonderadoGeneral: $scope.iPPG,
                                           ImgCedula: $scope.iCed,
                                           OtraBeca: "",
                                           OtraBecaHoras: -1,
                                           Cedula: $scope.ced,
                                           TipoBeca: "HA",
                                           Periodo: p
                                       };
                                   }

                                   $http.post(url3, consulta)
                                       .then(function successCallback(response) {
                                           alert("Enviado y guardado con exito");
                                           const loc = $scope.config.WebIp + "/PaginaWeb/homeEst.html";
                                           window.location = loc
                                       }, function errorCallback(response) {
                                           console.log(consulta);
                                           alert("Ha ocurrido un error, intentelo mas tarde");
                                       });
                               } else {
                                   alert("Esta fuera de fecha, por favor compruebe las fechas para el envio de formularios");
                               }
                           });
                   }
               } else {
                   alert("Debe de cargar las imagenes");
               }
           }
        });
});