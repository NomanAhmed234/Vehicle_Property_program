/*Write a main method for your Vehicle class that creates a few Vehicles and print out their field values. Make the fields in your Vehicle class private and add accessor and mutator methods for the fields.*/

namespace Lab6_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle 1 Details:");
            Vehicle v1 = new Vehicle();
            v1.setmodel("Audi4");
            v1.setengine("500cc");
            v1.setcolor("Red");
            Console.WriteLine("Model = {0}\nEngine = {1}\nColor = {2}\n", v1.getmodel(), v1.getengine(), v1.getcolor());

            Console.WriteLine("Vehicle 2 Details:");
            Vehicle v2 = new Vehicle();
            v2.setmodel("Toyota");
            v2.setengine("1000cc");
            v2.setcolor("Black");
            Console.WriteLine("Model = {0}\nEngine = {1}\nColor = {2}\n", v2.getmodel(), v2.getengine(), v2.getcolor());

            Console.WriteLine("Vehicle 3 Details:");
            Vehicle v3 = new Vehicle();
            v3.setmodel("Honda");
            v3.setengine("300cc");
            v3.setcolor("White");
            Console.WriteLine("Model = {0}\nEngine = {1}\nColor = {2}\n", v3.getmodel(), v3.getengine(), v3.getcolor());
        }
    }
}