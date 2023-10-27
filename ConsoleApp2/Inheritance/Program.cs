// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person[] persons = new Person[3]
{
    new Customer{FirstName="Yunus"}, new Student{FirstName="Ahmet"}, new Person{FirstName="Emre"}
};
foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string  LastName { get; set; }
}



class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}

// Bir nesneyi bir kere intheritance(her classın bir tane atası olabilir) yapabiliriz fakat bir nesne birden fazla implemantasyon yapabilir