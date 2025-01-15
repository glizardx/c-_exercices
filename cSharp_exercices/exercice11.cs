namespace Classes
{
    public class Car
    {
        // Member variables
        private string _model;
        private string _brand;
       // private bool _isLuxury;

        // Properties
        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string Brand
        {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " (Luxury)";
                }
                else
                {
                    return _brand;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Brand cannot be empty");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
            }
        }
        public bool IsLuxury
        {
            get;
            set;
        }

        // Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            _model = model;
            _brand = brand;
            IsLuxury = isLuxury;

            Console.WriteLine($"A new {_brand} {_model} has been created");
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the class Car
            Car audi = new Car("A3", "Audi", true);
            Car bmw = new Car("X5", "BMW", false);

            // Using the properties
            Console.WriteLine("Enter the brand of the car: ");
            audi.Brand = Console.ReadLine();
            
            // getting the value of the property
            Console.WriteLine("You entered the brand: " + audi.Brand);
            Console.WriteLine("You entered the brand: " + bmw.Brand);
            
            Console.ReadKey();
        }
    }
}
