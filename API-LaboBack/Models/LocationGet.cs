namespace API_LaboBack.Models
{
    public class LocationGet
    {
        public int LocationId { get; set; }
        public DateTime DebutLocation { get; set; }
        public DateTime? RetourLocation { get; set; }
        public double? Prix { get; set; }
        /*--------------------------------------*/
        public int UserId { get; set; }
    }
}
