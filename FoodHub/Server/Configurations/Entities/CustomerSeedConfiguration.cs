using FoodHub.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHub.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        { 
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Bel",
                    Address = "69 Yishun Avenue 7",
                    Email = "yasmintazi@icloud.com",
                    ContactNumber = "81443543"
                },
                
                new Customer
                {
                    Id = 2,
                    Name = "Mirza",
                    Address = "78 Macpherson Street 71",
                    Email = "mirzaepicftw@gmail.com",
                    ContactNumber = "81763881"
                 }
                ) ;
         
        }
    }
}
