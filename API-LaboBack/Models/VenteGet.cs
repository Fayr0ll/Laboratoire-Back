namespace API_LaboBack.Models
{
    public class VenteGet
    {
        public int VenteId { get; set; }
        public double Prix { get; set; }
        public int Quantitee { get; set; }
        public DateTime DateVente { get; set; }
        /*--------------------------------------*/
        public int UserId { get; set; }
    }
}
