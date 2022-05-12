namespace WareHouseAPI.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int YearModel { get; set; }
        public float Price { get; set; }
        public string Licensed { get; set; } = null!;
        public DateTime DateAdded { get; set; }
        public int WarehouseId { get; set; }

    }
}
