using Core.Interfaces;

namespace Infrastructure.Data
{
    public class ParkingRepository : IParkingRepository
    {
        private readonly List<string> _vehicles = new List<string>();

        public void AddVehicle(string licensePlate)
        {
            _vehicles.Add(licensePlate);
        }

        public void RemoveVehicle(string licensePlate)
        {
            _vehicles.Remove(licensePlate);
        }

        public List<string> ListVehicles()
        {
            return _vehicles;
        }
    }
}
