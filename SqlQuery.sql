/*Тип связи - Многие ко многим
Поэтому добавилась ещё одна таблица ProductsCategories
*/
select P.ProductName as Products, C.CategoryName as Categories
from Products as P
	left join ProductsCategories as PC 
	on P.Id = PC.ProductId
	left join Categories as C
	on PC.CategoryId = C.Id