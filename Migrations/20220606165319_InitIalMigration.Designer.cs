using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TestTaskUWP.Data;

namespace TestTaskUWP.Migrations
{
    [DbContext(typeof(TransactionContext))]
    [Migration("20220606165319_InitIalMigration")]
    partial class InitIalMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.3");

            modelBuilder.Entity("TestTaskUWP.Models.Transaction", b =>
                {
                    b.Property<int>("IdTransaction")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmountMoney");

                    b.Property<int>("AmountTransaction")
                        .HasMaxLength(10);

                    b.Property<string>("CategoryTransaction")
                        .IsRequired();

                    b.Property<string>("CommentTransaction")
                        .HasMaxLength(30);

                    b.Property<DateTime>("DateAndTimeTransaction");

                    b.Property<string>("TypeTransaction")
                        .IsRequired();

                    b.HasKey("IdTransaction");

                    b.ToTable("Transaction");
                });
        }
    }
}
