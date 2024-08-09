namespace Core.Interfaces
{
    public interface IParkingRepository
    {
        void AddVehicle(string licensePlate);
        void RemoveVehicle(string licensePlate);
        List<string> ListVehicles();
    }
}
