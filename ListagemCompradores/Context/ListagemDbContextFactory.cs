using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ListagemCompradores.Context
{
    public class ListagemDbContextFactory : IDesignTimeDbContextFactory<ListagemDbContext>
    {
        public ListagemDbContextFactory()
        {
        }

        public ListagemDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ListagemDbContext>();

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("databaseconnection.json")
                .Build();

            return new ListagemDbContext(optionsBuilder.Options, configuration);
        }
    }
}
