// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//bütün çalışanlara çalış komutu veriyoruz
IWorker[] workers = new IWorker[3]
{
        new Manager(),
        new Worker(),
        new Robot()
};

foreach (var worker in workers)
{
    worker.Work();
}


IEat[] eats = new IEat[2]
{
    new Manager(),
    new Worker()
    
};

foreach (var eat in eats)
{
    eat.Eat();
}

ISalary[] salaries = new ISalary[2]
{
    new Manager(), 
    new Worker()
};

foreach (var salary in salaries)
{
    salary.GetSalary();
}



interface IWorker
{
    void Work();
   
}

interface IEat
{
    void Eat();
    
}

interface ISalary
{
    void GetSalary();
}
class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine(" Yöneticiler Yemek Yedi");
    }

    public void GetSalary()
    {
        Console.WriteLine("Yönetici Maaşı Ödendi");
    }

    public void Work()
    {
        Console.WriteLine("Yöneticiler Çalışıtı");
    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("İşçiler Yemek Yedi");
    }

    public void GetSalary()
    {
        Console.WriteLine(" İşçi Maaşı Ödendi");
    }

    public void Work()
    {
        Console.WriteLine("İşçiler Çalıştı");
    }
}

class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot Çalışıtı");
    }
}