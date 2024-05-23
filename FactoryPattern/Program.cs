using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of tires for the vehicle you want to create:");
            int WheelCount;
            var input = int.Parse(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(input);
            vehicle.Drive();

            
        }
    }
}
