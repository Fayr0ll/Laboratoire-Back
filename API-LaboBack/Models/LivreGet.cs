namespace API_LaboBack.Models
{
    public class LivreGet
    {
        public int ISBN { get; set; }
        public string Titre { get; set; }
        public string Edition { get; set; }
        public int AnneeEdition { get; set; }
        public double Prix { get; set; }
        public bool Prime { get; set; }
    }
}
