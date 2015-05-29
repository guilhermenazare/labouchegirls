using System.Data.Entity.Migrations;

namespace labouchegirlsApi.Models
{
    internal sealed class Configuration : DbMigrationsConfiguration<EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EFContext";
        }

        protected override void Seed(EFContext context)
        {
            context.Atendentes.AddOrUpdate(
              p => p.Nome,
              new Atendente { Nome = "Keila Piti", Telefone = "12345678", Celular = "12345678", Endereco = "Rua Porto, 50", Descricao = "Faço com prazer", lat = "", log = "" },
              new Atendente { Nome = "Any Lee", Telefone = "12345678", Celular = "12345678", Endereco = "Rua Porto, 50", Descricao = "Faço com prazer", lat = "", log = "" },
              new Atendente { Nome = "Monica Mattos", Telefone = "12345678", Celular = "12345678", Endereco = "Rua Porto, 50", Descricao = "Faço com prazer", lat = "", log = "" }
            );
        } 
    }
}