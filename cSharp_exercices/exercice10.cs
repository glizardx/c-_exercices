namespace Classes
{
    public class Car
    {
        //member variables
        private string _model = "";
        private string _brand = "";
        public Car(string model, string brand) //constructor
        {
            _model = model;
            _brand = brand;
            Console.WriteLine($"A new {_brand} {_model} has been created");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an object of the class Car
            //creating an instance of the class Car
            Car audi = new Car("A3", "BMW");
            Car bmw = new Car("X5", "AUDI");
            
            Console.ReadKey();
        }
    }
}
