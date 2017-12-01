DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_ins_venda`(
 in _data varchar(20)
,in _id_cliente int
,in _id_produto int
)
begin

insert into venda(data,id_cliente,id_produto)
values (_data,_id_cliente,_id_produto);

select LAST_INSERT_ID();

end$$
DELIMITER ;

------------------------------------------------------------------------

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_upd_venda`(
 in _id int
,in _data varchar(20)
,in _id_cliente int
,in _id_produto int
)
begin

update venda
set
	 data = _data
	,id_cliente = _id_cliente
	,id_produto = _id_produto
where
	id = _id;
	

end$$
DELIMITER ;

-------------------------------------------------------------------------

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_del_venda`(
 in _id int
)
begin

delete from venda where id = _id;

end$$
DELIMITER ;

-------------------------------------------------------------------------

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_sel_venda`
begin

select * from venda;

end$$
DELIMITER ;

-------------------------------------------------------------------------