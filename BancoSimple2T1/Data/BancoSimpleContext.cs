﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BancoSimple2T1.Models;

namespace BancoSimple2T1.Data
{
    public class BancoSimpleContext : DbContext
    {
        public DbSet   <Cliente> Clientes { get; set; }
        public DbSet <Cuenta> Cuentas { get; set;}
        public DbSet <Transaccion> Transacciones { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\CarlosR; database = BancoSimple2M5; trusted_Connection = true; trustservercertificate = true;") ;

        }
        //Definicion de filtro global para solo incluir cuentas activas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>().HasQueryFilter ( c => c.Activa);
        }
        // Nombres que solo se encuentren pluralizados
    }
}
