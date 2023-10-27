// See https://aka.ms/new-console-template for more information

Customer customer1 = new Customer { Id=1,FirstName="Emre",LastName="Kara",City="Kocaeli"};
Customer customer2 = new Customer(2,"Yunus","Kara","Düzce");
Console.WriteLine(customer2.FirstName);
class Customer
{
    //default constructor customer1deki kullanım içindir.
    public Customer()
    {
        
    }
    //default constructor
    public Customer(int id,string firstName,string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }
    public  string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}
