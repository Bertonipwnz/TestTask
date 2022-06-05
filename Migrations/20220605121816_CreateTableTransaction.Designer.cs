using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TestTaskUWP.Models;
using TestTaskUWP.Data;
namespace TestTaskUWP.Migrations
{
    [DbContext(typeof(TransactionContext))]
    [Migration("20220605121816_CreateTableTransaction")]
    partial class CreateTableTransaction
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.3");

            modelBuilder.Entity("TestTaskUWP.Models.Transaction", b =>
                {
                    b.Property<int>("id_Transaction")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("amount_Money");

                    b.Property<int>("amount_Transaction")
                        .HasMaxLength(10);

                    b.Property<string>("category_Transaction")
                        .IsRequired();

                    b.Property<string>("comment_Transaction")
                        .HasMaxLength(30);

                    b.Property<DateTime>("date_and_Time_Transaction");

                    b.Property<string>("type_Transaction")
                        .IsRequired();

                    b.HasKey("id_Transaction");

                    b.ToTable("Transaction");
                });
        }
    }
}
