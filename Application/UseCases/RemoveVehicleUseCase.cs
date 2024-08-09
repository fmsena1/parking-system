using Core.Entities;
using Core.Interfaces;

namespace Application.UseCases
{
    public class RemoveVehicleUseCase
    {
        private readonly IParkingRepository _repository;

        public RemoveVehicleUseCase(IParkingRepository repository)
        {
            _repository = repository;
        }

        public void Execute(string licensePlate, int hours, decimal initialPrice, decimal pricePerHour)
        {
            var parking = new Parking(initialPrice, pricePerHour);
            decimal totalAmount = parking.CalculateTotalValue(hours);
            _repository.RemoveVehicle(licensePlate);
            Console.WriteLine($"The vehicle {licensePlate} was removed, and the total price was: $ {totalAmount}");
        }
    }
}
