//using DotNetCoreDataAccessLayer.Entitites;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DotNetCoreDataAccessLayer.DbContextFile
//{
//    public class DBContext : DBContext
//    {
//        public DBContext(DbContextOptions<DBContext> options): base(options)
//        {
            
//        }
//        public DbSet<Students> Students { get; set; }

//        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        //{
//        //    if (!optionsBuilder.IsConfigured)
//        //    {
//        //        optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=SampleApiDB;Integrated Security=True; TrustServerCertificate=True;");
//        //    }
//        //}
//        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        //{
//        //    optionsBuilder
//        //        .UseSqlServer(optionsBuilder.UseSqlServer

//        //            @"Server=(localdb)\mssqllocaldb;Database=Test",
//        //            providerOptions => { providerOptions.EnableRetryOnFailure(); });
//        //}

//    }
//}
