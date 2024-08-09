using Core.Interfaces;

namespace Application.UseCases
{
    public class AddVehicleUseCase
    {
        private readonly IParkingRepository _repository;

        public AddVehicleUseCase(IParkingRepository repository)
        {
            _repository = repository;
        }

        public void Execute(string placa)
        {
            _repository.AddVehicle(placa);
        }
    }
}
