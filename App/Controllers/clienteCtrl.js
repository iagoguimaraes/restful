angular.module('app').controller('clienteCtrl', function ($scope, $http) {

    $scope.clienteCadastrar = {};
    $scope.clienteEditar = {};
    $scope.clientes = [];

    $scope.obter = function () {
        $http({
            method: 'GET',
            url: "api/cliente",
        }).then(function (r) {
            $scope.clientes = r.data;
        });
    };

    $scope.cadastrar = function () {
        $http({
            method: 'POST',
            url: "api/cliente",
            data: $scope.clienteCadastrar,
        }).then(function (r) {
            $scope.clienteCadastrar = {};
            $scope.obter();
        });
    };

    $scope.editar = function () {
        $http({
            method: 'PUT',
            url: "api/cliente/" + $scope.clienteEditar.Id,
            data: $scope.clienteEditar,
        }).then(function (r) {
            $scope.clienteEditar = {};
            $scope.obter();
        });
    };

    $scope.remover = function () {
        if (confirm('certeza?')) {
            $http({
                method: 'DELETE',
                url: "api/cliente/" + $scope.clienteEditar.Id,
            }).then(function (r) {
                $scope.clienteEditar = {};
                $scope.obter();
            });
        }
    };

    $scope.popular = function (c) {
        $scope.clienteEditar = c;
    }

    $scope.obter();

});

