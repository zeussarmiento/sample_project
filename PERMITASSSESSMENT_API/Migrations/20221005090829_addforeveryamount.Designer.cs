﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PERMITASSSESSMENT_API.Data;

#nullable disable

namespace PERMITASSSESSMENT_API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221005090829_addforeveryamount")]
    partial class addforeveryamount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PERMITASSSESSMENT_API.Data.Assessment_Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal?>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AssessedFees")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessed_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Control_Num")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateAssessed")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FeeID")
                        .HasColumnType("int");

                    b.Property<int?>("ReferenceID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FeeID");

                    b.HasIndex("ReferenceID");

                    b.ToTable("Assessment_Details");
                });

            modelBuilder.Entity("PERMITASSSESSMENT_API.Data.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PERMITASSSESSMENT_API.Data.ComputationStyle", b =>
                {
                    b.Property<int>("CompStyleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompStyleID"), 1L, 1);

                    b.Property<string>("Desciption")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompStyleID");

                    b.ToTable("ComputationStyles");
                });

            modelBuilder.Entity("PERMITASSSESSMENT_API.Data.Fee", b =>
                {
                    b.Property<int>("FeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeeID"), 1L, 1);

                    b.Property<string>("FeeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsMandatory")
                        .HasColumnType("bit");

                    b.Property<int?>("PtypeID")
                        .HasColumnType("int");

                    b.HasKey("FeeID");

                    b.HasIndex("PtypeID");

                    b.ToTable("Fees");
                });

            modelBuilder.Entity("PERMITASSSESSMENT_API.Data.FeeComputation", b =>
                {
                    b.Property<int>("FeeComputationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeeComputationID"), 1L, 1);

                    b.Property<decimal?>("AdditionalAmount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int?>("CompStyleID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Excess")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("FeeID")
                        .HasColumnType("int");

                    b.Property<decimal?>("ForEveryAmount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("LowerBracket")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("UpperBracker")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FeeComputationID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("CompStyleID");

                    b.HasIndex("FeeID");

                    b.ToTable("FeeComputations");
                });

            modelBuilder.Entity("PERMITASSSESSMENT_API.Data.OPFeeReference", b =>
                {
                    b.Property<int>("ReferenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReferenceID"), 1L, 1);

                    b.Property<string>("AccountCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlgfCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CtrlCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DboCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fund")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FundGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FundSubgroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeObject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeSubdesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeSubgroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubsidiaryCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferenceID");

                    b.ToTable("OPFeeReferences");
                });

            modelBuilder.Entity("PERMITASSSESSMENT_API.Data.PermitType", b =>
                {
                    b.Property<int>("PtypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PtypeID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PtypeID");

                    b.ToTable("PermitTypes");
                });

            modelBuilder.Entity("PERMITASSSESSMENT_API.Data.Assessment_Detail", b =>
                {
                    b.HasOne("PERMITASSSESSMENT_API.Data.Fee", "Fee")
                        .WithMany()
                        .HasForeignKey("FeeID");

                    b.HasOne("PERMITASSSESSMENT_API.Data.OPFeeReference", "OPFeeReference")
                        .WithMany()
                        .HasForeignKey("ReferenceID");

                    b.Navigation("Fee");

                    b.Navigation("OPFeeReference");
                });

            modelBuilder.Entity("PERMITASSSESSMENT_API.Data.Fee", b =>
                {
                    b.HasOne("PERMITASSSESSMENT_API.Data.PermitType", "PermitType")
                        .WithMany()
                        .HasForeignKey("PtypeID");

                    b.Navigation("PermitType");
                });

            modelBuilder.Entity("PERMITASSSESSMENT_API.Data.FeeComputation", b =>
                {
                    b.HasOne("PERMITASSSESSMENT_API.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("PERMITASSSESSMENT_API.Data.ComputationStyle", "ComputationStyle")
                        .WithMany()
                        .HasForeignKey("CompStyleID");

                    b.HasOne("PERMITASSSESSMENT_API.Data.Fee", "Fee")
                        .WithMany()
                        .HasForeignKey("FeeID");

                    b.Navigation("Category");

                    b.Navigation("ComputationStyle");

                    b.Navigation("Fee");
                });
#pragma warning restore 612, 618
        }
    }
}
