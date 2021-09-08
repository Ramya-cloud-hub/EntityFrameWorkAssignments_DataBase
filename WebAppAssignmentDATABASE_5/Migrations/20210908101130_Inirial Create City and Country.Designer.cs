﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppAssignmentDATABASE_5.Models;

namespace WebAppAssignmentDATABASE_5.Migrations
{
    [DbContext(typeof(ExDbContext))]
    [Migration("20210908101130_Inirial Create City and Country")]
    partial class InirialCreateCityandCountry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppAssignmentDATABASE_5.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("CountryCityId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryCityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WebAppAssignmentDATABASE_5.Models.Country", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CityId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("WebAppAssignmentDATABASE_5.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonCityCityId")
                        .HasColumnType("int");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PersonPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.HasIndex("PersonCityCityId");

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("WebAppAssignmentDATABASE_5.Models.City", b =>
                {
                    b.HasOne("WebAppAssignmentDATABASE_5.Models.Country", null)
                        .WithMany("ListOfCities")
                        .HasForeignKey("CountryCityId");
                });

            modelBuilder.Entity("WebAppAssignmentDATABASE_5.Models.Person", b =>
                {
                    b.HasOne("WebAppAssignmentDATABASE_5.Models.City", "PersonCity")
                        .WithMany("PeopleListInCity")
                        .HasForeignKey("PersonCityCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonCity");
                });

            modelBuilder.Entity("WebAppAssignmentDATABASE_5.Models.City", b =>
                {
                    b.Navigation("PeopleListInCity");
                });

            modelBuilder.Entity("WebAppAssignmentDATABASE_5.Models.Country", b =>
                {
                    b.Navigation("ListOfCities");
                });
#pragma warning restore 612, 618
        }
    }
}
