--https://pastebin.com/gnzVSxTD

select product.product_name as Продукт, isnull(catgory.category_name, 'Категория отсутствует') as Категория
from product
left join productCategory on product.product_id = productCategory.product_id
left join category on productCategory.category_id = category.category_id