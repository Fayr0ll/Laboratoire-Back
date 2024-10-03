using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_LaboBack.Entities
{
    public class User : IUser
    {
        private object email;
        private object password;

        public User(string email, string mdp)
        {
            this.Email = email;
            this.MDP = mdp;
        }

        //Propriétés
        public int UserId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Localite { get; set; }
        public string Pays { get; set; }
        public string Email { get; set; }
        public string MDP { get; set; }

        //ForeignKey

        //Propriétés liens
        public List<Vente> Ventes { get; set; }
        public List<Location> Locations { get; set; }

    }
}
