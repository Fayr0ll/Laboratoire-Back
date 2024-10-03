using EF = EF_LaboBack.Entities;
using BLL = BLL_LaboBack.Entities;

namespace BLL_LaboBack.Mapper
{
    public static class Mapper
    {
        public static EF.Livre ToEF(this BLL.Livre entity)
        {
            return new EF.Livre
            {
                ISBN = entity.ISBN,
                Titre = entity.Titre,
                Edition = entity.Edition,
                AnneeEdition = entity.AnneeEdition,
                Prix = entity.Prix,
                Prime = entity.Prime
            };
        }

        public static BLL.Livre ToBLL(this EF.Livre entity)
        {
            return new BLL.Livre
            {
                ISBN = entity.ISBN,
                Titre = entity.Titre,
                Edition = entity.Edition,
                AnneeEdition = entity.AnneeEdition,
                Prix = entity.Prix,
                Prime = entity.Prime
            };
        }

        public static EF.Auteur ToEF(this BLL.Auteur entity)
        {
            return new EF.Auteur
            {
                AuteurId = entity.AuteurId,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                NbrOuvrage = entity.NbrOuvrage
            };
        }

        public static BLL.Auteur ToBLL(this EF.Auteur entity)
        {
            return new BLL.Auteur
            {
                AuteurId = entity.AuteurId,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                NbrOuvrage = entity.NbrOuvrage
            };
        }

        public static EF.User ToEF(this BLL.User entity)
        {
            return new EF.User
            {
                UserId = entity.UserId,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal = entity.CodePostal,
                Localite = entity.Localite,
                Pays = entity.Pays,
                Email = entity.Email,
                MDP = entity.MDP,
                Salage = "entity.Salage"
            };
        }

        public static BLL.User ToBLL(this EF.User entity)
        {
            return new BLL.User
            {
                UserId = entity.UserId,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal = entity.CodePostal,
                Localite = entity.Localite,
                Pays = entity.Pays,
                Email = entity.Email,
                MDP = entity.MDP
            };
        }

        public static BLL.Genre ToBLL(this EF.Genre entity)
        {
            return new BLL.Genre
            {
                GenreId = entity.GenreId,
                NomGenre = entity.NomGenre
            };
        }

        public static EF.Genre ToEF(this BLL.Genre entity)
        {
            return new EF.Genre
            {
                GenreId = entity.GenreId,
                NomGenre = entity.NomGenre
            };
        }

        public static BLL.Location ToBLL(this EF.Location entity)
        {
            return new BLL.Location
            {
                LocationId = entity.LocationId,
                DebutLocation = entity.DebutLocation,
                RetourLocation = entity.RetourLocation,
                Prix = entity.Prix,
                UserId = entity.UserId
            };
        }

        public static EF.Location ToEF(this BLL.Location entity)
        {
            return new EF.Location
            {
                LocationId = entity.LocationId,
                DebutLocation = entity.DebutLocation,
                RetourLocation = entity.RetourLocation,
                Prix = entity.Prix,
                UserId = entity.UserId
            };
        }

        public static BLL.Vente ToBLL(this EF.Vente entity)
        {
            return new BLL.Vente
            {
                VenteId = entity.VenteId,
                DateVente = entity.DateVente,
                Prix = entity.Prix,
                Quantitee = entity.Quantitee,
                UserId = entity.UserId
            };
        }

        public static EF.Vente ToEF(this BLL.Vente entity)
        {
            return new EF.Vente
            {
                VenteId = entity.VenteId,
                DateVente = entity.DateVente,
                Prix = entity.Prix,
                Quantitee = entity.Quantitee,
                UserId = entity.UserId
            };
        }

        public static BLL.Bibliotheque ToBLL(this EF.Bibliotheque entity)
        {
            return new BLL.Bibliotheque
            {
                BibliothequeId = entity.BibliothequeId,
                Rue = entity.Rue,
                Numero = entity.Numero,
                Localite = entity.Localite,
                CodePostal = entity.CodePostal,
                Pays = entity.Pays,
            };
        }

        public static EF.Bibliotheque ToEF(this BLL.Bibliotheque entity)
        {
            return new EF.Bibliotheque
            {
                BibliothequeId = entity.BibliothequeId,
                Rue = entity.Rue,
                Numero = entity.Numero,
                Localite = entity.Localite,
                CodePostal = entity.CodePostal,
                Pays = entity.Pays,
            };
        }

        public static EF.Reservation ToEF(this BLL.Reservation entity)
        {
            return new EF.Reservation
            {
                ReservationId = entity.ReservationId,
                DateReservation = entity.DateReservation,
                Acompte = entity.Acompte
            };
        }

        public static BLL.Reservation ToBLL(this EF.Reservation entity)
        {
            return new BLL.Reservation
            {
                ReservationId = entity.ReservationId,
                DateReservation = entity.DateReservation,
                Acompte = entity.Acompte
            };
        }
    }
}
