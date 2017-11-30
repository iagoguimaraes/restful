angular.module('app').controller('produtoCtrl', function ($scope, $http) {

    $scope.produtoCadastrar = {};
    $scope.produtoEditar = {};
    $scope.produtos = [];

    $scope.obter = function () {
        $http({
            method: 'GET',
            url: "api/produto",
        }).then(function (r) {
            $scope.produtos = r.data;
        });
    };

    $scope.cadastrar = function () {
        $http({
            method: 'POST',
            url: "api/produto",
            data: $scope.produtoCadastrar,
        }).then(function (r) {
            $scope.produtoCadastrar = {};
            $scope.obter();
        });
    };

    $scope.editar = function () {
        $http({
            method: 'PUT',
            url: "api/produto/" + $scope.produtoEditar.Id,
            data: $scope.produtoEditar,
        }).then(function (r) {
            $scope.produtoEditar = {};
            $scope.obter();
        });
    };

    $scope.remover = function () {
        if (confirm('certeza?')) {
            $http({
                method: 'DELETE',
                url: "api/produto/" + $scope.produtoEditar.Id,
            }).then(function (r) {
                $scope.produtoEditar = {};
                $scope.obter();
            });
        }
    };

    $scope.popular = function (c) {
        $scope.produtoEditar = c;
    }

    $scope.obter();

});

