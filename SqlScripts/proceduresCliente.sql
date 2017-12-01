DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_ins_cliente`(
 in _nome varchar(20)
)
begin

insert into cliente(nome)
values (_nome);

select LAST_INSERT_ID();

end$$
DELIMITER ;

------------------------------------------------------------------------

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_upd_cliente`(
 in _id int
,in _nome varchar(20)
)
begin

update cliente
set
	 nome = _nome
where
	id = _id;
	

end$$
DELIMITER ;

-------------------------------------------------------------------------

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_del_cliente`(
 in _id int
)
begin

delete from cliente where id = _id;

end$$
DELIMITER ;

-------------------------------------------------------------------------

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_sel_cliente`
begin

select * from cliente;

end$$
DELIMITER ;

-------------------------------------------------------------------------