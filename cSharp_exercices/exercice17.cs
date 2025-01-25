using System.IO.Pipes;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product();
            Product keyboard = new Product();

            mouse.Id = GetIntInput("Enter the mouse id: ");
            mouse.Name = GetStringInput("Enter the mouse name: ");
            mouse.Price = GetDoubleInput("Enter the mouse price: ");
            mouse.Type = EproductType.Product;

            Console.WriteLine(mouse);
        }

        static int GetIntInput(string prompt)
        {
            Console.WriteLine(prompt);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return result;
        }

        static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static double GetDoubleInput(string prompt)
        {
            Console.Write(prompt);
            double result;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid double.");
            }
            return result;
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EproductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public EproductType Type { get; set; }

        public double PriceInDollars(double dolar)
        {
            return Price * dolar;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Price in Dollars: {Price * 5.20}, Type: {Type}";
        }
    }

    enum EproductType
    {
        Product = 1,
        Service = 2,
    }
}
