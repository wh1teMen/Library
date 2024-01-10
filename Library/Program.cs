using Library.Data;
using Microsoft.EntityFrameworkCore;

namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
               .ConfigureWebHostDefaults(
               webBuilder => { webBuilder.UseStartup<Startup>(); })
               .Build().Run();

        }
    }
}