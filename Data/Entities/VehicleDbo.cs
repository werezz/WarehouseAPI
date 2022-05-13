namespace WareHouseAPI.Data.Entities
{
    public class VehicleDbo
    {
        public int Id { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int YearModel { get; set; }
        public double Price { get; set; }
        public string Licensed { get; set; } = null!;
        public DateTime DateAdded { get; set; }
        public int WarehouseId { get; set; }
    }
}
