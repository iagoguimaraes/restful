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
        templateUrl: "Views/produto.html"
    })
    .when("/venda", {
        templateUrl: "Views/venda.html"
    })
    .when("/vendas", {
        templateUrl: "Views/vendas.html"
    });
});