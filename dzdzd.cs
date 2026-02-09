using System;

public class Person
{
    // Свойства класса
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
}


using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
}

public class Student : Person
{
    public string University { get; set; }

    public Student(string name, int age, string university) 
        : base(name, age)
    {
        University = university;
    }

    public void Study()
    {
        Console.WriteLine($"{Name} учится в {University}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Университет: {University}");
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject) 
        : base(name, age)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} преподаёт {Subject}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Предмет: {Subject}");
    }
}

public class Doctor : Person
{
    public string Specialization { get; set; }

    public Doctor(string name, int age, string specialization) 
        : base(name, age)
    {
        Specialization = specialization;
    }

    public void Treat()
    {
        Console.WriteLine($"{Name} лечит пациентов по специализации {Specialization}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Специализация: {Specialization}");
    }
}


using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
}

public class Student : Person
{
    public string University { get; set; }

    public Student(string name, int age, string university) 
        : base(name, age)
    {
        University = university;
    }

    public void Study()
    {
        Console.WriteLine($"{Name} учится в {University}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Университет: {University}");
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} преподаёт {Subject}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Предмет: {Subject}");
    }
}

public class Doctor : Person
{
    public string Specialization { get; set; }

public Doctor(string name, int age, string specialization)
        : base(name, age)
    {
        Specialization = specialization;
    }

    public void Treat()
    {
        Console.WriteLine($"{Name} лечит пациентов по специализации {Specialization}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Специализация: {Specialization}");
    }
}


using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
}

public class Student : Person
{
    public string University { get; set; }

    public Student(string name, int age, string university)
        : base(name, age)
    {
        University = university;
    }

    public void Study()
    {
        Console.WriteLine($"{Name} учится в {University}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Университет: {University}");
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} преподаёт {Subject}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Предмет: {Subject}");
    }
}

public class Doctor : Person
{
    public string Specialization { get; set; }

    public Doctor(string name, int age, string specialization)
        : base(name, age)
    {
        Specialization = specialization;
    }

    public void Treat()
    {
        Console.WriteLine($"{Name} лечит пациентов по специализации {Specialization}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Специализация: {Specialization}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Анна", 20, "МГУ");

        Teacher teacher = new Teacher("Сергей", 45, "Математика");

        Doctor doctor = new Doctor("Елена", 38, "Кардиология");


        Console.WriteLine("=== Студент ===");
        student.ShowInfo();
        student.Study();

        Console.WriteLine("\n=== Преподаватель ===");
        teacher.ShowInfo();
        teacher.Teach();
      
        Console.WriteLine("\n=== Врач ===");
        doctor.ShowInfo();
        doctor.Treat();
    }
}


using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }

    public void SayHello()
    {
        Console.WriteLine($"{Name} говорит: «Привет!»");
    }
}

public class Student : Person
{
    public string University { get; set; }

    public Student(string name, int age, string university)
        : base(name, age)
    {
        University = university;
    }

    public void Study()
    {
        Console.WriteLine($"{Name} учится в {University}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Университет: {University}");
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} преподаёт {Subject}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Предмет: {Subject}");
    }
}

public class Doctor : Person
{
    public string Specialization { get; set; }

    public Doctor(string name, int age, string specialization)
        : base(name, age)
    {
        Specialization = specialization;
    }

    public void Treat()
    {
        Console.WriteLine($"{Name} лечит пациентов по специализации {Specialization}.");
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Специализация: {Specialization}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Анна", 20, "МГУ");
        Teacher teacher = new Teacher("Сергей", 45, "Математика");
        Doctor doctor = new Doctor("Елена", 38, "Кардиология");


        Console.WriteLine("=== Студент ===");
        student.ShowInfo();
        student.Study();
        student.SayHello();  

        Console.WriteLine("\n=== Преподаватель ===");
        teacher.ShowInfo();
        teacher.Teach();
        teacher.SayHello();  

        Console.WriteLine("\n=== Врач ===");
        doctor.ShowInfo();
        doctor.Treat();
        doctor.SayHello();   
    }
}
