// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

//interface new'lenemez
//IPersonManager customerManager =new CustomerManager();
//customerManager.Add();
//customerManager.Update();

//IPersonManager employeeManager =new EmployeeManager();
//employeeManager.Add();
//employeeManager.Update();

ProjectManager projectManager =new ProjectManager();
projectManager.Add( new InternManager());
projectManager.Add(new CustomerManager());
projectManager.Add(new EmployeeManager());

projectManager.Update(new InternManager());
projectManager.Update(new CustomerManager());
projectManager.Update(new EmployeeManager());


interface IPersonManager
{
    //unImplemented operation
    void Add();
    void Update();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        //Müşteri ekleme kodları yazılır.

        Console.WriteLine("Müşterşi Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Güncelleme yapıldı");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Güncelleme yapıldı");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajer Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajer güncellendi");
    }
}


class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        
        personManager.Add();
        
    }

    public void Update(IPersonManager personManager)
    {
        personManager.Update();
    }
}