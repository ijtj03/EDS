var mA = angular.module('DoForm', []);

mA.controller('DoFormCtrl', function($scope, $http) {
    $http.get('../Scripts - Web/config.json')
       .then(function(res){
           $scope.config = res.data;
           const url1 = $scope.config.MyApi + "api/Departamentos/GetAllDeps";
           $http.get(url1)
               .then(function (res) {
                   $scope.deps = res.data;
               });
        });
});