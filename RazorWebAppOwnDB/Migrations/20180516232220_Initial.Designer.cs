﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RazorWebAppOwnDB.Models;
using System;

namespace RazorWebAppOwnDB.Migrations
{
    [DbContext(typeof(MemberContext))]
    [Migration("20180516232220_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorWebAppOwnDB.Models.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrentCourses");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("InitiationDate");

                    b.Property<string>("LastName");

                    b.Property<string>("Major");

                    b.HasKey("ID");

                    b.ToTable("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
