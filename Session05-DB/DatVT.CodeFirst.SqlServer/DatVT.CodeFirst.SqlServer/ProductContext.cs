using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.CodeFirst.SqlServer
{
    public class ProductContext : DbContext //class Cha, Con đại diện cho 1 db mình sẽ xài
    {
        private string connectionString = @"Server=localhost,1433;Initial Catalog=ContactDB;Integrated Security=True;
                                           Trusted_Connection=true;Encrypt=false";
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        //tui table products trong tương lai sẽ chứa nhiều new Product() 

    }
}
