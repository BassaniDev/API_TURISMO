using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using API_TURISMO.Models;

namespace API_TURISMO.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<API_TURISMO.Models.P_Turistico> P_Turistico { get; set; }
        //public DbSet<Teste_Web_Turismo2.Models.Estado> Estados { get; set; }
        //public DbSet<Teste_Web_Turismo2.Models.Cidade> Cidades { get; set; }
    }
}
