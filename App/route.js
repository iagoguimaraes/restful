angular.module('app').config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "Views/main.html"
    })
    .when("/cliente", {
        templateUrl: "Views/cliente.html",
        controller: "clienteCtrl"
    })
    .when("/produto", {
        templateUrl: "Views/produto.html",
        controller: "produtoCtrl"
    })
    .when("/venda", {
        templateUrl: "Views/venda.html",
        controller: "vendaCtrl"
    })
    .when("/vendas", {
        templateUrl: "Views/vendas.html",
        controller: "vendasCtrl"
    });
});