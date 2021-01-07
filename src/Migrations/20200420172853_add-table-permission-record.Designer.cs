﻿// <auto-generated />
using System;
using IdentityServer4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdentityServer4.Migrations
{
    [DbContext(typeof(UMDbContext))]
    [Migration("20200420172853_add-table-permission-record")]
    partial class addtablepermissionrecord
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IdentityServer4.Models.OTPTemp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<DateTime>("Expired");

                    b.Property<string>("OTP");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("OTPTemp");
                });

            modelBuilder.Entity("IdentityServer4.Models.PermissionRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActivityCode");

                    b.Property<string>("ActivityName");

                    b.Property<string>("Description");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("PermissionRecord");
                });

            modelBuilder.Entity("IdentityServer4.Models.PermissionRoleMapping", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PermissionId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("PermissionRoleMapping");
                });

            modelBuilder.Entity("IdentityServer4.Models.Roles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("DeleteBy")
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("RoleName");

                    b.Property<int?>("RoleType");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("IdentityServer4.Models.UserRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("IdentityServer4.Models.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("CurrentOTPCode");

                    b.Property<string>("DeleteBy")
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailVerified");

                    b.Property<DateTime?>("ExpiredOTP");

                    b.Property<string>("FamilyName");

                    b.Property<string>("GivenName");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("UserType");

                    b.Property<string>("Username");

                    b.Property<string>("WebSite");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IdentityServer4.Models.PermissionRoleMapping", b =>
                {
                    b.HasOne("IdentityServer4.Models.PermissionRecord", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IdentityServer4.Models.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityServer4.Models.UserRoles", b =>
                {
                    b.HasOne("IdentityServer4.Models.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IdentityServer4.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
