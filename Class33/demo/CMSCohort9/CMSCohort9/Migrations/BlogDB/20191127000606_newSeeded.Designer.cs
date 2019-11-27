﻿// <auto-generated />
using CMSCohort9.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CMSCohort9.Migrations.BlogDB
{
    [DbContext(typeof(BlogDBContext))]
    [Migration("20191127000606_newSeeded")]
    partial class newSeeded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMSCohort9.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Content = "This is my first post, and it's pretty super duper cool",
                            Title = "Hello World"
                        },
                        new
                        {
                            ID = 2,
                            Content = "Oh, you can’t help that,” said the Cat: “we’re all mad here. I’m mad. You’re mad.” “How do you know I’m mad?” said Alice. “You must be,” said the Cat, or you wouldn’t have come here.",
                            Title = "We're All Mad"
                        },
                        new
                        {
                            ID = 3,
                            Content = "It's no use going back to yesterday, because I was a different person then.",
                            Title = "Yesterday"
                        },
                        new
                        {
                            ID = 4,
                            Content = "She generally gave herself very good advice (though she very seldom followed it)",
                            Title = "Good advice"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
