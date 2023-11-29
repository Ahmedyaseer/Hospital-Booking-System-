﻿// <auto-generated />
using System;
using Hospital.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.DAL.Migrations
{
    [DbContext(typeof(HopitalContext))]
    [Migration("20231129090528_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hospital.DAL.AddOnApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorDepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorPrice")
                        .HasColumnType("int");

                    b.Property<string>("DoctorProfile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mobileNumber")
                        .HasColumnType("int");

                    b.Property<int>("watingList")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Hospital.DAL.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBook")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PatSubmitDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("PatSubmitTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TimeOfBook")
                        .HasColumnType("time");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<string>("patId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patientid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("patientid");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Hospital.DAL.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HosptialID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("deptImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HosptialID");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The cardiology department specializes in the diagnosis and treatment of heart diseases and conditions.",
                            HosptialID = 1,
                            Name = "Cardiology",
                            deptImage = "https://www.centrecardiolaval.com/wp-content/uploads/2023/07/medical-concept-with-heart-and-electrocardiogram-r-2021-08-31-15-58-51-utc-1536x1024.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The neurology department specializes in the diagnosis and treatment of diseases and conditions of the brain, spinal cord, and peripheral nerves.",
                            HosptialID = 1,
                            Name = "Neurology",
                            deptImage = "https://muthumeenakshihospitals.com/img/Neurology-and-Neurosurgery.png"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The orthopedics department specializes in the diagnosis and treatment of diseases and conditions of the musculoskeletal system, including bones, joints, muscles, and ligaments.",
                            HosptialID = 1,
                            Name = "Orthopedics",
                            deptImage = "https://sayaamed.com/wp-content/uploads/2022/01/Orthopedics-in-sayaa-med-1.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The pediatrics department specializes in the diagnosis and treatment of diseases and conditions of children from birth to adolescence.",
                            HosptialID = 1,
                            Name = "Pediatrics",
                            deptImage = "https://wakeforestpediatrics.com/wp-content/uploads/2020/10/Choosing-a-Pediatrician.jpeg"
                        },
                        new
                        {
                            Id = 5,
                            Description = "The surgery department specializes in the diagnosis and treatment of diseases and conditions that require surgical intervention.",
                            HosptialID = 1,
                            Name = "Surgery",
                            deptImage = "https://i0.wp.com/post.medicalnewstoday.com/wp-content/uploads/sites/3/2023/03/cosmetic_surgery_GettyImages1313477062_Header-1024x575.jpg?w=1155&h=1528"
                        },
                        new
                        {
                            Id = 6,
                            Description = "The cardiology department specializes in the diagnosis and treatment of heart diseases and conditions.",
                            HosptialID = 2,
                            Name = "Cardiology",
                            deptImage = "https://www.centrecardiolaval.com/wp-content/uploads/2023/07/medical-concept-with-heart-and-electrocardiogram-r-2021-08-31-15-58-51-utc-1536x1024.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Description = "The neurology department specializes in the diagnosis and treatment of diseases and conditions of the brain, spinal cord, and peripheral nerves.",
                            HosptialID = 2,
                            Name = "Neurology",
                            deptImage = "https://muthumeenakshihospitals.com/img/Neurology-and-Neurosurgery.png"
                        },
                        new
                        {
                            Id = 8,
                            Description = "The orthopedics department specializes in the diagnosis and treatment of diseases and conditions of the musculoskeletal system, including bones, joints, muscles, and ligaments.",
                            HosptialID = 2,
                            Name = "Orthopedics",
                            deptImage = "https://sayaamed.com/wp-content/uploads/2022/01/Orthopedics-in-sayaa-med-1.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Description = "The pediatrics department specializes in the diagnosis and treatment of diseases and conditions of children from birth to adolescence.",
                            HosptialID = 2,
                            Name = "Pediatrics",
                            deptImage = "https://wakeforestpediatrics.com/wp-content/uploads/2020/10/Choosing-a-Pediatrician.jpeg"
                        },
                        new
                        {
                            Id = 10,
                            Description = "The surgery department specializes in the diagnosis and treatment of diseases and conditions that require surgical intervention.",
                            HosptialID = 2,
                            Name = "Surgery",
                            deptImage = "https://i0.wp.com/post.medicalnewstoday.com/wp-content/uploads/sites/3/2023/03/cosmetic_surgery_GettyImages1313477062_Header-1024x575.jpg?w=1155&h=1528"
                        });
                });

            modelBuilder.Entity("Hospital.DAL.Disease", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PatientID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("diseaseDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diseaseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diseasetreatment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientID");

                    b.ToTable("Disease");
                });

            modelBuilder.Entity("Hospital.DAL.Doctor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mobileNumber")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("watingList")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Hospital.DAL.Hosptial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hosptial");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Alex",
                            Name = "Alex"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Cairo",
                            Name = "Cairo"
                        });
                });

            modelBuilder.Entity("Hospital.DAL.Patient", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("Hospital.DAL.WorkSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("WorkSchedules");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginProvider", "ProviderKey", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Hospital.DAL.Booking", b =>
                {
                    b.HasOne("Hospital.DAL.Doctor", "Doctor")
                        .WithMany("Bookings")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.DAL.Patient", "patient")
                        .WithMany("Bookings")
                        .HasForeignKey("patientid");

                    b.Navigation("Doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Hospital.DAL.Department", b =>
                {
                    b.HasOne("Hospital.DAL.Hosptial", "Hosptial")
                        .WithMany("Departments")
                        .HasForeignKey("HosptialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hosptial");
                });

            modelBuilder.Entity("Hospital.DAL.Disease", b =>
                {
                    b.HasOne("Hospital.DAL.Patient", "Patient")
                        .WithMany("Disease")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital.DAL.Doctor", b =>
                {
                    b.HasOne("Hospital.DAL.Department", "Department")
                        .WithMany("Doctors")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Hospital.DAL.WorkSchedule", b =>
                {
                    b.HasOne("Hospital.DAL.Doctor", "Doctor")
                        .WithMany("WorkSchedules")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Hospital.DAL.AddOnApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Hospital.DAL.AddOnApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.DAL.AddOnApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Hospital.DAL.AddOnApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital.DAL.Department", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("Hospital.DAL.Doctor", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("WorkSchedules");
                });

            modelBuilder.Entity("Hospital.DAL.Hosptial", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Hospital.DAL.Patient", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Disease");
                });
#pragma warning restore 612, 618
        }
    }
}
