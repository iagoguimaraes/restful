angular.module('app').controller('vendasCtrl', function ($scope, $http) {

    $scope.vendas = [];

    $scope.obter = function () {
        $http({
            method: 'GET',
            url: "api/venda",
        }).then(function (r) {
            $scope.vendas = r.data;
        });
    };

    $scope.obter();

});

