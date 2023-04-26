﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResourceIdea.Models;

#nullable disable

namespace resourceideaui.Migrations
{
    [DbContext(typeof(ResourceIdeaDBContext))]
    partial class ResourceIdeaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("ResourceIdea.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ResourceIdea.Models.Client", b =>
                {
                    b.Property<string>("ClientId")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CompanyCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Industry")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("ClientId");

                    b.HasIndex("CompanyCode");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.Company", b =>
                {
                    b.Property<string>("CompanyCode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.HasKey("CompanyCode");

                    b.ToTable("Company", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.Engagement", b =>
                {
                    b.Property<string>("EngagementId")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Color")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("EngagementId");

                    b.HasIndex("ClientId");

                    b.ToTable("Project", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.EngagementTask", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("EngagementId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Manager")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Partner")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("EngagementId");

                    b.ToTable("Job", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.JobPosition", b =>
                {
                    b.Property<int>("JobPositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobPositionId"));

                    b.Property<string>("CompanyCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("JobLevel")
                        .HasColumnType("int");

                    b.Property<string>("PositionTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("JobPositionId");

                    b.HasIndex("CompanyCode");

                    b.ToTable("JobPosition", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.JobSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("JobId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("SkillId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("SkillId");

                    b.ToTable("JobSkill", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.License", b =>
                {
                    b.Property<string>("LicenseKey")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("CompanyCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("LicenseTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("LicenseKey");

                    b.HasIndex("CompanyCode");

                    b.HasIndex("LicenseTypeId");

                    b.ToTable("License", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.LicenseType", b =>
                {
                    b.Property<int>("LicenseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LicenseTypeId"));

                    b.Property<decimal>("Fee")
                        .HasColumnType("money");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Plan")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValueSql("('')");

                    b.HasKey("LicenseTypeId");

                    b.ToTable("LicenseType", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.LineOfService", b =>
                {
                    b.Property<Guid>("LineOfServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<string>("CompanyCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("LineOfServiceId");

                    b.HasIndex(new[] { "CompanyCode" }, "IX_CompanyCode");

                    b.ToTable("LineOfService", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.LineOfServiceJob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<string>("JobId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<Guid>("LineOfServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "JobId" }, "IX_JobId");

                    b.HasIndex(new[] { "LineOfServiceId" }, "IX_LineOfServiceId");

                    b.ToTable("LineOfServiceJob", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.MigrationHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ContextKey")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("Model")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("MigrationId", "ContextKey")
                        .HasName("PK_dbo.__MigrationHistory");

                    b.ToTable("__MigrationHistory", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.Resource", b =>
                {
                    b.Property<string>("ResourceId")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("CompanyCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("JobPositionId")
                        .HasColumnType("int");

                    b.Property<string>("JobsManagedColor")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("TerminationDate")
                        .HasColumnType("date");

                    b.HasKey("ResourceId");

                    b.HasIndex("CompanyCode");

                    b.HasIndex("JobPositionId");

                    b.HasIndex(new[] { "Email" }, "UX_ResourceEmail")
                        .IsUnique();

                    b.ToTable("Resource", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.ResourceSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ResourceId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<string>("SkillId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.HasIndex("SkillId");

                    b.ToTable("ResourceSkill", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.RoleGrouping", b =>
                {
                    b.Property<Guid>("RoleGroupingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<string>("CompanyCode")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("RoleGroupingId");

                    b.HasIndex(new[] { "CompanyCode" }, "IX_CompanyCode");

                    b.ToTable("RoleGrouping", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.RoleGroupingMember", b =>
                {
                    b.Property<Guid>("RoleGroupingMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newsequentialid())");

                    b.Property<Guid>("RoleGroupingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("RoleGroupingMemberId");

                    b.HasIndex(new[] { "RoleGroupingId" }, "IX_RoleGroupingId");

                    b.ToTable("RoleGroupingMember", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.Skill", b =>
                {
                    b.Property<string>("SkillId")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("SkillId");

                    b.ToTable("Skill", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.TaskAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Details")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ResourceId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("TaskId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.HasIndex("TaskId");

                    b.ToTable("JobResource", (string)null);
                });

            modelBuilder.Entity("ResourceIdea.Models.Client", b =>
                {
                    b.HasOne("ResourceIdea.Models.Company", "CompanyCodeNavigation")
                        .WithMany("Clients")
                        .HasForeignKey("CompanyCode")
                        .IsRequired()
                        .HasConstraintName("FK_Client_Company");

                    b.Navigation("CompanyCodeNavigation");
                });

            modelBuilder.Entity("ResourceIdea.Models.Engagement", b =>
                {
                    b.HasOne("ResourceIdea.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .IsRequired()
                        .HasConstraintName("FK_Project_Client");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("ResourceIdea.Models.EngagementTask", b =>
                {
                    b.HasOne("ResourceIdea.Models.Engagement", "Engagement")
                        .WithMany("Jobs")
                        .HasForeignKey("EngagementId")
                        .IsRequired()
                        .HasConstraintName("FK_Job_Project");

                    b.Navigation("Engagement");
                });

            modelBuilder.Entity("ResourceIdea.Models.JobPosition", b =>
                {
                    b.HasOne("ResourceIdea.Models.Company", "CompanyCodeNavigation")
                        .WithMany("JobPositions")
                        .HasForeignKey("CompanyCode")
                        .IsRequired()
                        .HasConstraintName("FK_JobPosition_CompanyCode");

                    b.Navigation("CompanyCodeNavigation");
                });

            modelBuilder.Entity("ResourceIdea.Models.JobSkill", b =>
                {
                    b.HasOne("ResourceIdea.Models.EngagementTask", "Job")
                        .WithMany("JobSkills")
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("FK_JobSkill_Job");

                    b.HasOne("ResourceIdea.Models.Skill", "Skill")
                        .WithMany("JobSkills")
                        .HasForeignKey("SkillId")
                        .IsRequired()
                        .HasConstraintName("FK_JobSkill_Skill");

                    b.Navigation("Job");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("ResourceIdea.Models.License", b =>
                {
                    b.HasOne("ResourceIdea.Models.Company", "CompanyCodeNavigation")
                        .WithMany("Licenses")
                        .HasForeignKey("CompanyCode")
                        .IsRequired()
                        .HasConstraintName("FK_License_Company");

                    b.HasOne("ResourceIdea.Models.LicenseType", "LicenseType")
                        .WithMany("Licenses")
                        .HasForeignKey("LicenseTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_License_Type");

                    b.Navigation("CompanyCodeNavigation");

                    b.Navigation("LicenseType");
                });

            modelBuilder.Entity("ResourceIdea.Models.LineOfService", b =>
                {
                    b.HasOne("ResourceIdea.Models.Company", "CompanyCodeNavigation")
                        .WithMany("LineOfServices")
                        .HasForeignKey("CompanyCode")
                        .IsRequired()
                        .HasConstraintName("FK_dbo.LineOfService_dbo.Company_CompanyCode");

                    b.Navigation("CompanyCodeNavigation");
                });

            modelBuilder.Entity("ResourceIdea.Models.LineOfServiceJob", b =>
                {
                    b.HasOne("ResourceIdea.Models.EngagementTask", "Job")
                        .WithMany("LineOfServiceJobs")
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("FK_dbo.LineOfServiceJob_dbo.Job_JobId");

                    b.HasOne("ResourceIdea.Models.LineOfService", "LineOfService")
                        .WithMany("LineOfServiceJobs")
                        .HasForeignKey("LineOfServiceId")
                        .IsRequired()
                        .HasConstraintName("FK_dbo.LineOfServiceJob_dbo.LineOfService_LineOfServiceId");

                    b.Navigation("Job");

                    b.Navigation("LineOfService");
                });

            modelBuilder.Entity("ResourceIdea.Models.Resource", b =>
                {
                    b.HasOne("ResourceIdea.Models.Company", "CompanyCodeNavigation")
                        .WithMany("Resources")
                        .HasForeignKey("CompanyCode")
                        .IsRequired()
                        .HasConstraintName("FK_Resource_Company");

                    b.HasOne("ResourceIdea.Models.JobPosition", "JobPosition")
                        .WithMany("Resources")
                        .HasForeignKey("JobPositionId")
                        .HasConstraintName("FK_Resource_JobPosition");

                    b.Navigation("CompanyCodeNavigation");

                    b.Navigation("JobPosition");
                });

            modelBuilder.Entity("ResourceIdea.Models.ResourceSkill", b =>
                {
                    b.HasOne("ResourceIdea.Models.Resource", "Resource")
                        .WithMany("ResourceSkills")
                        .HasForeignKey("ResourceId")
                        .IsRequired()
                        .HasConstraintName("FK_ResourceSkill_Resource");

                    b.HasOne("ResourceIdea.Models.Skill", "Skill")
                        .WithMany("ResourceSkills")
                        .HasForeignKey("SkillId")
                        .IsRequired()
                        .HasConstraintName("FK_ResourceSkill_Skill");

                    b.Navigation("Resource");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("ResourceIdea.Models.RoleGrouping", b =>
                {
                    b.HasOne("ResourceIdea.Models.Company", "CompanyCodeNavigation")
                        .WithMany("RoleGroupings")
                        .HasForeignKey("CompanyCode")
                        .IsRequired()
                        .HasConstraintName("FK_dbo.RoleGrouping_dbo.Company_CompanyCode");

                    b.Navigation("CompanyCodeNavigation");
                });

            modelBuilder.Entity("ResourceIdea.Models.RoleGroupingMember", b =>
                {
                    b.HasOne("ResourceIdea.Models.RoleGrouping", "RoleGrouping")
                        .WithMany("RoleGroupingMembers")
                        .HasForeignKey("RoleGroupingId")
                        .IsRequired()
                        .HasConstraintName("FK_dbo.RoleGroupingMember_dbo.RoleGrouping_RoleGroupingId");

                    b.Navigation("RoleGrouping");
                });

            modelBuilder.Entity("ResourceIdea.Models.TaskAssignment", b =>
                {
                    b.HasOne("ResourceIdea.Models.Resource", "Resource")
                        .WithMany("JobResources")
                        .HasForeignKey("ResourceId")
                        .IsRequired()
                        .HasConstraintName("FK_JobResource_Resource");

                    b.HasOne("ResourceIdea.Models.EngagementTask", "Task")
                        .WithMany("TaskAssignments")
                        .HasForeignKey("TaskId")
                        .IsRequired()
                        .HasConstraintName("FK_JobResource_Job");

                    b.Navigation("Resource");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("ResourceIdea.Models.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ResourceIdea.Models.Company", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("JobPositions");

                    b.Navigation("Licenses");

                    b.Navigation("LineOfServices");

                    b.Navigation("Resources");

                    b.Navigation("RoleGroupings");
                });

            modelBuilder.Entity("ResourceIdea.Models.Engagement", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("ResourceIdea.Models.EngagementTask", b =>
                {
                    b.Navigation("JobSkills");

                    b.Navigation("LineOfServiceJobs");

                    b.Navigation("TaskAssignments");
                });

            modelBuilder.Entity("ResourceIdea.Models.JobPosition", b =>
                {
                    b.Navigation("Resources");
                });

            modelBuilder.Entity("ResourceIdea.Models.LicenseType", b =>
                {
                    b.Navigation("Licenses");
                });

            modelBuilder.Entity("ResourceIdea.Models.LineOfService", b =>
                {
                    b.Navigation("LineOfServiceJobs");
                });

            modelBuilder.Entity("ResourceIdea.Models.Resource", b =>
                {
                    b.Navigation("JobResources");

                    b.Navigation("ResourceSkills");
                });

            modelBuilder.Entity("ResourceIdea.Models.RoleGrouping", b =>
                {
                    b.Navigation("RoleGroupingMembers");
                });

            modelBuilder.Entity("ResourceIdea.Models.Skill", b =>
                {
                    b.Navigation("JobSkills");

                    b.Navigation("ResourceSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
