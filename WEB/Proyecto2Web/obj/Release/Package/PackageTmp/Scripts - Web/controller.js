var mA = angular.module('App', []);

mA.controller('TodoCtrl', function($scope, $http) {
    $http.get('../Scripts - Web/config.json')
        .then(function (res) {
            window.localStorage.clear();
            $scope.todos = res.data;                
        });
});