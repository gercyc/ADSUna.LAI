﻿// <auto-generated />
using System;
using ADSUna.LAI.Portal.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ADSUna.LAI.Portal.Web.Migrations
{
    [DbContext(typeof(DBAccessContext))]
    partial class DBAccessContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ADSUna.LAI.Portal.Web.Models.Aluno", b =>
                {
                    b.Property<int>("IdAluno")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<string>("Nome");

                    b.Property<string>("RegistroAcademico");

                    b.HasKey("IdAluno");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("ADSUna.LAI.Portal.Web.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ADSUna.LAI.Portal.Web.Models.CommunityPost", b =>
                {
                    b.Property<string>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("PostContent");

                    b.Property<DateTime>("PostCreatedDate");

                    b.Property<string>("PostTitle");

                    b.Property<string>("UserId");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("CommunityPost");
                });

            modelBuilder.Entity("ADSUna.LAI.Portal.Web.Models.CommunityPostLikes", b =>
                {
                    b.Property<string>("IdReaction")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PostId");

                    b.Property<DateTime>("ReactionDate");

                    b.Property<string>("UserId");

                    b.HasKey("IdReaction");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("CommunityPostLikes");
                });

            modelBuilder.Entity("ADSUna.LAI.Portal.Web.Models.CommunityPost", b =>
                {
                    b.HasOne("ADSUna.LAI.Portal.Web.Models.ApplicationUser", "PostedBy")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ADSUna.LAI.Portal.Web.Models.CommunityPostLikes", b =>
                {
                    b.HasOne("ADSUna.LAI.Portal.Web.Models.CommunityPost", "Post")
                        .WithMany()
                        .HasForeignKey("PostId");

                    b.HasOne("ADSUna.LAI.Portal.Web.Models.ApplicationUser", "LikedBy")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
