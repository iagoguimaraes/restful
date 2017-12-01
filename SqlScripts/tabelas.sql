drop schema if exists restful;
create schema restful;
use restful;

create table cliente(
 id int auto_increment primary key
,nome varchar(150)
);

create table produto(
 id int auto_increment primary key
,descricao varchar(100)
);

create table venda(
 id int auto_increment primary key
,data varchar(20)
,id_cliente int
,id_produto int
,constraint fk_produto_cliente foreign key (id_cliente) references cliente(id_cliente)
,constraint fk_produto_produto foreign key (id_produto) references produto(id_produto)
);