﻿// <auto-generated />
using System;
using DojoCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DojoCenter.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200424215912_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DojoCenter.Models.Association", b =>
                {
                    b.Property<int>("AssocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PartyId");

                    b.Property<int>("UserId");

                    b.HasKey("AssocationId");

                    b.HasIndex("PartyId");

                    b.HasIndex("UserId");

                    b.ToTable("Associations");
                });

            modelBuilder.Entity("DojoCenter.Models.Party", b =>
                {
                    b.Property<int>("PartyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Duration");

                    b.Property<string>("DurationType");

                    b.Property<int>("PlannerId");

                    b.Property<DateTime?>("Time");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("PartyId");

                    b.HasIndex("PlannerId");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("DojoCenter.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DojoCenter.Models.Association", b =>
                {
                    b.HasOne("DojoCenter.Models.Party", "Party")
                        .WithMany("Users")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DojoCenter.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DojoCenter.Models.Party", b =>
                {
                    b.HasOne("DojoCenter.Models.User", "Planner")
                        .WithMany("CreatedParties")
                        .HasForeignKey("PlannerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
