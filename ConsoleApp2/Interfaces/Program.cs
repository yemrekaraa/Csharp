// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//IntrafacesIntro();

using Interfaces;

//CustomerManager customerManager =new CustomerManager();
//customerManager.Add(new OracleCustomerDal());

ICustomerDal[] customerDals = new ICustomerDal[2] 
{
    new OracleCustomerDal(),
    new SqlServerCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}





PergonManager personManager = new PergonManager();

Customer customer = new Customer
{
    Id = 1,
    FirstName = "yemre",
    LastName = "Kara",
    Address = "Düzce"
};
personManager.Add(customer);

Student student = new Student
{
    Id = 2,
    FirstName = "Şule",
    LastName = "Evcimen",
    Departmant = "hukuk"

};
personManager.Add(student);
interface IPerson
{
     int Id { get; set; }
     string FirstName { get; set; }
     string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student :IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PergonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}