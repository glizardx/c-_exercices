namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Notebook", 2500.00, 5.24);
            
            Console.WriteLine(p1.Id);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1.PriceInDolar(p1.Price));

            Console.ReadKey();
        }
    }

    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        static double Dolar = 5.24;
        
        public Product(int id, string name, double price, double dolar)
        {
            Id = id;
            Name = name;
            Price = price;
            Dolar = dolar;
        }
        
        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
}
