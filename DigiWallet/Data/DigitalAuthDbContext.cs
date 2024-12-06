﻿using DigiWallet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DigiWallet.Data
{
    public class DigitalAuthDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public DigitalAuthDbContext(DbContextOptions<DigitalAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

}
