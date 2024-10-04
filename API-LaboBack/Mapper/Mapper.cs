using BLL = BLL_LaboBack.Entities;
using API_LaboBack.Models;
using Microsoft.EntityFrameworkCore;
using API_LaboBack.Models.Client;

namespace API_LaboBack.Mapper
{
    public static class Mapper
    {
        public static LivreGet ToAPI(this BLL.Livre entity)
        {
            return new LivreGet
            {
                ISBN = entity.ISBN,
                Titre = entity.Titre,
                Edition = entity.Edition,
                AnneeEdition = entity.AnneeEdition,
                Prix = entity.Prix,
                Prime = entity.Prime
            };
        }

        public static BLL.Livre ToBLL(this LivrePost entity)
        {
            return new BLL.Livre
            {
                Titre = entity.Titre,
                Edition = entity.Edition,
                AnneeEdition = entity.AnneeEdition,
                Prix = entity.Prix,
                Prime = entity.Prime
            };
        }

        public static AuteurGet ToAPI(this BLL.Auteur entity)
        {
            return new AuteurGet
            {
                AuteurId = entity.AuteurId,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                NbrOuvrage = entity.NbrOuvrage
            };
        }

        public static BLL.Auteur ToBLL(this AuteurPost entity)
        {
            return new BLL.Auteur
            {
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                NbrOuvrage = entity.NbrOuvrage
            };
        }

        public static UserGet ToAPI(this BLL.User entity)
        {
            return new UserGet
            {
                UserId = entity.UserId,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Pays = entity.Pays,
                Email = entity.Email
            };
        }

        public static BLL.User ToBLL(this UserPost entity)
        {
            return new BLL.User
            {
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

        public static GenreGet ToAPI(this BLL.Genre entity)
        {
            return new GenreGet
            {
                GenreId = entity.GenreId,
                NomGenre = entity.NomGenre
            };
        }

        public static BLL.Genre ToBLL(this GenrePost entity)
        {
            return new BLL.Genre
            {
                NomGenre = entity.NomGenre,
            };
        }

        public static VenteGet ToAPI(this BLL.Vente entity)
        {
            return new VenteGet
            {
                VenteId = entity.VenteId,
                DateVente = entity.DateVente,
                Prix = entity.Prix,
                Quantitee = entity.Quantitee,
                UserId = entity.UserId
            };
        }

        public static BLL.Vente ToBLL(this VentePost entity)
        {
            return new BLL.Vente
            {
                DateVente = entity.DateVente,
                Prix = entity.Prix,
                Quantitee = entity.Quantitee,
                UserId = entity.UserId
            };
        }

        public static BibliothequeGet ToAPI(this BLL.Bibliotheque entity)
        {
            return new BibliothequeGet
            {
                BibliothequeId = entity.BibliothequeId,
                Rue = entity.Rue,
                Numero = entity.Numero,
                Localite = entity.Localite,
                CodePostal = entity.CodePostal,
                Pays = entity.Pays,
            };
        }

        public static BLL.Bibliotheque ToBLL(this BibliothequePost entity)
        {
            return new BLL.Bibliotheque
            {
                Rue = entity.Rue,
                Numero = entity.Numero,
                Localite = entity.Localite,
                CodePostal = entity.CodePostal,
                Pays = entity.Pays,
            };
        }

        public static LocationGet ToAPI(this BLL.Location entity)
        {
            return new LocationGet
            {
                LocationId = entity.LocationId,
                DebutLocation = entity.DebutLocation,
                RetourLocation = entity.RetourLocation,
                Prix = entity.Prix,
                UserId = entity.UserId
            };
        }

        public static BLL.Location ToBLL(this LocationPost entity)
        {
            return new BLL.Location
            {
                DebutLocation = entity.DebutLocation,
                Prix = entity.Prix,
                UserId = entity.UserId
            };
        }

        public static BLL.Location ToBLL(this LocationPut entity)
        {
            return new BLL.Location
            {
                RetourLocation = entity.RetourLocation
            };
        }

        public static ReservationGet ToAPI(this BLL.Reservation entity)
        {
            return new ReservationGet
            {
                ReservationId = entity.ReservationId,
                DateReservation = entity.DateReservation,
                Acompte = entity.Acompte
            };
        }

        public static BLL.Reservation ToBLL(this ReservationPost entity)
        {
            return new BLL.Reservation
            {
                DateReservation = entity.DateReservation,
                Acompte = entity.Acompte
            };
        }
        //public static BLL.User ToBLL(this UserLoginForm form)
        //{
        //    if(form is null) throw new ArgumentNullException(nameof(form));
        //    return new BLL.User(form.Email,form.MDP);
        //}

        //public static BLL.User ToBLL(this UserRegisterForm form)
        //{
        //    if (form is null) throw new ArgumentNullException(nameof(form));
        //    return new BLL.User(form.Email, form.MDP);
        //}

        //public static UserListeItem ToListItem(this BLL.User entity) 
        //{ 
        //    if (entity is null) throw new ArgumentNullException(nameof(entity));
        //    return new UserListeItem() { UserId = entity.UserId, Email = entity.Email };
        //}

        //public static UserDetailsAccount ToDetails(this BLL.User entity)
        //{
        //    if(entity is null) throw new ArgumentNullException(nameof(entity));
        //    return new UserDetailsAccount()
        //    {
        //        Nom = entity.Nom,
        //        Prenom = entity.Prenom,
        //        Email = entity.Email,
        //        Pays = entity.Pays
        //    };
        //}
    }
}

