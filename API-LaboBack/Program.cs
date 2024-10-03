using COMMON_LaboBack.Repositories;
using EF_LaboBack;
using BLL = BLL_LaboBack;

namespace API_LaboBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DataContext>();
            builder.Services.AddScoped<IAuteurRepository<BLL.Entities.Auteur>, BLL.Services.AuteurService>();
            builder.Services.AddScoped<IBibliothequeRepository<BLL.Entities.Bibliotheque>, BLL.Services.BibliothequeService>();
            builder.Services.AddScoped<IGenreRepository<BLL.Entities.Genre>, BLL.Services.GenreService>();
            builder.Services.AddScoped<ILivreRepository<BLL.Entities.Livre>, BLL.Services.LivreService>();
            builder.Services.AddScoped<ILocationRepository<BLL.Entities.Location>, BLL.Services.LocationService>();
            builder.Services.AddScoped<IReservationRepository<BLL.Entities.Reservation>, BLL.Services.ReservationService>();
            builder.Services.AddScoped<IUserRepository<BLL.Entities.User>, BLL.Services.UserService>();
            builder.Services.AddScoped< IVenteRepository < BLL.Entities.Vente>, BLL.Services.VenteService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
