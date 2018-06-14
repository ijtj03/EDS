var mA = angular.module('DoForm', []);

mA.controller('DoFormCtrl', function ($scope, $http) {
    var date = new Date();

    console.log(date.getDate());
    $scope.boton = function () {
        if ($scope.s) {
            document.getElementById("studentHours").disabled = false;
            document.getElementById("scholarshipId").disabled = false;
            document.getElementById("department").disabled = false;
            
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
               });
           const url2 = $scope.config.MyApi + "api/Varios/GetAllCursos";
           $http.get(url2)
               .then(function (res) {
                   $scope.cursos = res.data;
               });
           $scope.cImg = function (id) {
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
                       //const url3 = $scope.config.MyApi + "api/Formularios/GuardarForm";
                       const url3 = "http://localhost:64698/api/Formularios/GuardarForm";
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
                       alert("enviado con exito");
                   }
               } else {
                   alert("Debe de cargar las imagenes");
               }
           }
        });
});