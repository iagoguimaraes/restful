angular.module('app').controller('clienteCtrl', function ($scope) {

    $scope.cadastrar = {};
    $scope.editar = {};
    $scope.remover = 0;
    $scope.clientes = [];


    $scope.obter = function () {
        $.ajax({
            method: 'GET',
            url: "api/cliente",
        }).done(function (r) {
            $scope.clientes = r;
            $scope.$apply();
        });
    };

    $scope.cadastrar = function () {
        $.ajax({
            method: 'POST',
            url: "api/cliente",
            data: $scope.cadastrar,
        }).done(function (r) {
            $scope.cadastrar = {};
            $scope.obter();
        });
    };

    $scope.editar = function () {
        $.ajax({
            method: 'PUT',
            url: "api/cliente/" + $scope.editar.id,
            data: $scope.editar,
        }).done(function (r) {
            $scope.editar = {};
            $scope.obter();
        });
    };

    $scope.remover = function () {
        $.ajax({
            method: 'DELETE',
            url: "api/cliente/" + $scope.remover,
        }).done(function (r) {
            $scope.remover = 0;
            $scope.obter();
        });
    };

    $scope.obter();

});

