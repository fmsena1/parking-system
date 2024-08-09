using Core.Interfaces;
using Infrastructure.Data;
using Application.UseCases;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IParkingRepository repository = new ParkingRepository();
            var addVehicleUseCase = new AddVehicleUseCase(repository);
            var removeVehicleUseCase = new RemoveVehicleUseCase(repository);
            var listVehiclesUseCase = new ListVehiclesUseCase(repository);

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Add vehicle");
                Console.WriteLine("2 - Remove vehicle");
                Console.WriteLine("3 - List vehicles");
                Console.WriteLine("4 - Exit");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter the license plate of the vehicle to park:");
                        var licensePlateToAdd = Console.ReadLine();
                        addVehicleUseCase.Execute(licensePlateToAdd);
                        break;
                    case "2":
                        Console.WriteLine("Enter the license plate of the vehicle to remove:");
                        var licensePlateToRemove = Console.ReadLine();
                        Console.WriteLine("Enter the number of hours the vehicle was parked:");
                        if (int.TryParse(Console.ReadLine(), out int hours))
                        {
                            removeVehicleUseCase.Execute(licensePlateToRemove, hours, 6, 2);
                        }
                        else
                        {
                            Console.WriteLine("Invalid number of hours.");
                        }
                        break;
                    case "3":
                        listVehiclesUseCase.Execute();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
