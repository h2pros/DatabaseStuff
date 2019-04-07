﻿// <auto-generated />
using System;
using H2Pros.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace H2Pros.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20190406142316_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("H2Pros.model.Consumption", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("User");

                    b.Property<int>("coldWaterFlow");

                    b.Property<DateTime>("dateCreated");

                    b.Property<int>("hotWaterFlow");

                    b.HasKey("id");

                    b.HasIndex("User");

                    b.ToTable("consumptions");
                });

            modelBuilder.Entity("H2Pros.model.User", b =>
                {
                    b.Property<int>("cpr")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<string>("name");

                    b.HasKey("cpr");

                    b.ToTable("users");
                });

            modelBuilder.Entity("H2Pros.model.Consumption", b =>
                {
                    b.HasOne("H2Pros.model.User", "Usercpr")
                        .WithMany("consumptions")
                        .HasForeignKey("User");
                });
#pragma warning restore 612, 618
        }
    }
}