namespace testwebapi.Models
{
    public class Buyer
    {
        public Guid rowguid { get; set; }
        public int ID { get; set; }
        public string Email { get; set; }
        public string ID_Product { get; set; }
        public int Total { get; set; }
        public int isActive { get; set; }
    }
}
