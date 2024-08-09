using Core.Interfaces;

namespace Application.UseCases
{
    public class ListVehiclesUseCase
    {
        private readonly IParkingRepository _repository;

        public ListVehiclesUseCase(IParkingRepository repository)
        {
            _repository = repository;
        }

        public void Execute()
        {
            var vehicles = _repository.ListVehicles();
            if (vehicles.Any())
            {
                Console.WriteLine("The parked vehicles are:");
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine("There are no parked vehicles.");
            }
        }
    }
}
