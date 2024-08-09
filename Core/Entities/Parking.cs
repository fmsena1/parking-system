namespace Core.Entities
{
    public class Parking
    {
        public decimal InitialPrice { get; private set; }
        public decimal PricePerHour { get; private set; }
        public List<string> Vehicles { get; private set; } = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            InitialPrice = initialPrice;
            PricePerHour = pricePerHour;
        }

        public void AddVehicle(string plate)
        {
            Vehicles.Add(plate);
        }

        public void RemoveVehicle(string plate)
        {
            Vehicles.Remove(plate);
        }

        public decimal CalculateTotalValue(int hours)
        {
            return InitialPrice + PricePerHour * hours;
        }
    }
}