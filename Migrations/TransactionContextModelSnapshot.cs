using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TestTaskUWP.Models;

namespace TestTaskUWP.Migrations
{
    [DbContext(typeof(TransactionContext))]
    partial class TransactionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.3");

            modelBuilder.Entity("TestTaskUWP.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Price");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("TestTaskUWP.Models.Transaction", b =>
                {
                    b.Property<int>("id_Transaction")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("amount_Transaction");

                    b.Property<string>("category_Transaction");

                    b.Property<string>("comment_Transaction");

                    b.Property<DateTime>("date_and_Time_Transaction");

                    b.Property<string>("type_Transaction");

                    b.HasKey("id_Transaction");

                    b.ToTable("Transaction");
                });
        }
    }
}
