namespace ConsoleApp1;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}

public class Cat : Animal
{
    public override void MakeMeow()
    {
        Console.WriteLine("Meow");
    }
}

public class Fish : Animal
{
    public override void MakeSound()
    {
        throw new InvalidOperationException("Fish cannot make sound");
    }
}