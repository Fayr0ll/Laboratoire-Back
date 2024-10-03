using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace API_LaboBack.Models.Client
{
    public class UserListeItem
    {
        public int UserId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Localite { get; set; }
        public string Pays { get; set; }
        public string Email { get; set; }
    }
}
