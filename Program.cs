using System;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal is making a sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog is barking");
    }

    public void Fetch()
    {
        Console.WriteLine("Dog is fetching");
    }
}

public class Program
{
    public static void Main()
    {
        Dog myDog = new Dog();
        myDog.MakeSound(); 
        myDog.Fetch();     

        Console.WriteLine();

        Animal myAnimal = myDog; // Upcasting: Dog is treated as an Animal

        myAnimal.MakeSound();

        

        Console.WriteLine();

        Animal[] animals = new Animal[2];
        animals[0] = new Dog();
        animals[1] = new Animal();

        foreach (Animal animal in animals)
        {
            animal.MakeSound(); 
        }
    }
}
