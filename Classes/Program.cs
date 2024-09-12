// TODO: Instantiate your objects and test your exercise solutions with print statements here.

namespace Classes;
class Program
{ 

     static void Main(String[] args)
    {
        Student Robert = new Student("Robert", 1, 1, 4.0);
        Console.WriteLine("The Student class works! " + Robert.Name + " is a student!");
    }
}