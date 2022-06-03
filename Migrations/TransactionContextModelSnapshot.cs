using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TestTaskUWP.ViewModels;

namespace TestTaskUWP.Migrations
{
    [DbContext(typeof(TransactionContext))]
    partial class TransactionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.3");

            modelBuilder.Entity("TestTaskUWP.Models.Transaction", b =>
                {
                    b.Property<int>("ID_Transaction")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount_Transaction");

                    b.Property<string>("Category_Transaction");

                    b.Property<string>("Comment_Transaction");

                    b.Property<DateTime>("Date_and_Time_Transaction");

                    b.Property<string>("Type_Transaction");

                    b.HasKey("ID_Transaction");

                    b.ToTable("Transaction");
                });
        }
    }
}
