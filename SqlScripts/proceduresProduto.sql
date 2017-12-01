DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_ins_produto`(
 in _descricao varchar(20)
)
begin

insert into produto(descricao)
values (_descricao);

select LAST_INSERT_ID();

end$$
DELIMITER ;

------------------------------------------------------------------------

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_upd_produto`(
 in _id int
,in _descricao varchar(20)
)
begin

update produto
set
	 descricao = _descricao
where
	id = _id;
	

end$$
DELIMITER ;

-------------------------------------------------------------------------

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_del_produto`(
 in _id int
)
begin

delete from produto where id = _id;

end$$
DELIMITER ;

-------------------------------------------------------------------------

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_sel_produto`
begin

select * from produto;

end$$
DELIMITER ;

-------------------------------------------------------------------------