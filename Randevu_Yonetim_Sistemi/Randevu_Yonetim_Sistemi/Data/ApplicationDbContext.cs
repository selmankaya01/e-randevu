using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Randevu_Yonetim_Sistemi.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Randevu_Yonetim_Sistemi.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment>Appointments { get; set; }
    }
}
