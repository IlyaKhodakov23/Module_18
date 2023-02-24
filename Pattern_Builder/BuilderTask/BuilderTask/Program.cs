using System.Text;

namespace BuilderTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Объект завода, который будет заниматься производством
            var carPlant = new CarPlant();
            // производство автомобилей
            Conveyor builder = new CarConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();
        }
    }
}