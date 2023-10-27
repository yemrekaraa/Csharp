// See https://aka.ms/new-console-template for more information
using OOP1;

Product product1 = new Product();
product1.ID = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.ProductPrice = 500;
product1.UnitInStock = 3;

Product product2 = new Product() {Id=2,CategoryId=5,UnitInStock=5,ProductName="Kalem",
ProductPrice=35};
//PascalCase   //camelCase
ProductManager productManager= new ProductManager();
productManager.Add();
