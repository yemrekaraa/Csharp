// See https://aka.ms/new-console-template for more information

Customer customer1=new Customer() { Id=1,FirstName="Emre",LastName="Kara",City="Düzce"};
Customer customer3 = new Customer();
customer3.Id = 3;


Customer customer2 = new Customer(2,"derin","güzel","antep");

Console.WriteLine(customer2.FirstName);

class Customer
{
    public Customer() 
    {
        
    }
    //default constructor
    public Customer(int id,string firstName,string lastName,string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
        
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}