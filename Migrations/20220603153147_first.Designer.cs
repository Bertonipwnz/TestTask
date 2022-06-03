using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TestTaskUWP.Models;

namespace TestTaskUWP.Migrations
{
    [DbContext(typeof(ViewModels.TransactionContext))]
    [Migration("20220603153147_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.3");

            modelBuilder.Entity("TestTaskUWP.Models.Model+Transaction", b =>
                {
                    b.Property<int>("ID_Transaction")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type_Transaction");

                    b.HasKey("ID_Transaction");

                    b.ToTable("Transaction");
                });
        }
    }
}
