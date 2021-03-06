namespace WareHouseAPI.Data.Entities
{
    public class WarehouseDbo
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Lat { get; set; }
        public double Long { get; set; }
        public string Location { get; set; } = null!;
    }
}
