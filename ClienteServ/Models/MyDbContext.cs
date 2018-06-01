namespace ClienteServ
{
    using ClienteServ.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyDbContext : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Model1' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'ClienteServ.Model1' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Model1'  en el archivo de configuración de la aplicación.
        public MyDbContext()
            : base(nameOrConnectionString: "MyDbContext")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Users> Users { get; set; }
        public DbSet<Post> Post { get; set; }
    }


    
}