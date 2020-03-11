select

orc.*

from Orcamento orc 
inner join ItemsOrc ior on (orc.Codigo = ior.Codigo)
inner join Produtos pdt on (ior.Produto = pdt.Codigo)
where 
orc.Data between @dti and @dtf
and orc.Cliente = @cliente
order by orc.Codigo desc