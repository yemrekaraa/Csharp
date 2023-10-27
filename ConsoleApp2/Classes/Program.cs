// See https://aka.ms/new-console-template for more information
using Classes;

Console.WriteLine("Hello, World!");
CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer
{
    Id = 2,
    FirstName = "Test",
    LastName = "sads",
    City = "Testasdasd"
};
Console.WriteLine(customer.FirstName);
