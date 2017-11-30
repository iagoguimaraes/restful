angular.module('app').controller('vendaCtrl', function ($scope, $http) {

    $scope.vendaCadastrar = {};
    $scope.clientes = [];
    $scope.produtos = [];

    $scope.cadastrar = function () {
        $http({
            method: 'POST',
            url: "api/venda",
            data: $scope.vendaCadastrar,
        }).then(function (r) {
            $scope.vendaCadastrar = {};
        });
    };

    $http({
        method: 'GET',
        url: "api/cliente",
    }).then(function (r) {
        $scope.clientes = r.data;
    });

    $http({
        method: 'GET',
        url: "api/produto",
    }).then(function (r) {
        $scope.produtos = r.data;
    });

});

