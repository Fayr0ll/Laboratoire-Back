namespace API_LaboBack.Models
{
    public class BibliothequeGet
    {
        public int BibliothequeId { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Localite { get; set; }
        public string Pays { get; set; }
    }
}
