﻿using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Domain.Identity;
using Infrastructure.Persistence.Configurations.Application;

namespace Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }

        //Notes added. 
        public DbSet<Note> Notes { get; set; }

        //GetByIdAsync added. 
        public Task<Address> GetByIdAsync(string ıd, bool v)
        {
            throw new NotImplementedException();
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configurations
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //Override for homework
            modelBuilder.ApplyConfiguration(new AccountCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            //Note and NoteCategory Configurations added.
            modelBuilder.ApplyConfiguration(new NoteCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new NoteConfiguration());
            

            // Ignores
            modelBuilder.Ignore<User>();
            modelBuilder.Ignore<Role>();
            modelBuilder.Ignore<UserRole>();
            modelBuilder.Ignore<RoleClaim>();
            modelBuilder.Ignore<UserToken>();
            modelBuilder.Ignore<UserClaim>();
            modelBuilder.Ignore<UserLogin>();

            base.OnModelCreating(modelBuilder);
        }

       
    }

}