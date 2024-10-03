using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_LaboBack.Entities
{
    public class Ecrit : IEcrit
    {
        //Propriété

        //ForeignKey
        public int ISBN { get; set; }
        public int AuteurId { get; set; }

        //Propriétés liens
        public Livre Livre { get; set; }
        public Auteur Auteur { get; set; }
    }
}
