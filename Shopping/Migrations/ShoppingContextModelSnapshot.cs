﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shopping.Models.db;

namespace Shopping.Migrations
{
    [DbContext(typeof(ShoppingContext))]
    partial class ShoppingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shopping.Models.db.TbAdminstrator", b =>
                {
                    b.Property<string>("AdminName")
                        .HasColumnName("Admin_name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AdminPw")
                        .HasColumnName("Admin_Pw")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.ToTable("TbAdminstrator");
                });

            modelBuilder.Entity("Shopping.Models.db.TbBill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Bill_ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BillDate")
                        .HasColumnName("Bill_Date")
                        .HasColumnType("datetime");

                    b.Property<int?>("BillQty")
                        .HasColumnName("Bill_Qty")
                        .HasColumnType("int");

                    b.Property<double?>("BillTotal")
                        .HasColumnName("Bill_Total")
                        .HasColumnType("float");

                    b.Property<int?>("CusId")
                        .HasColumnName("Cus_ID")
                        .HasColumnType("int");

                    b.Property<int?>("PdId")
                        .HasColumnName("Pd_ID")
                        .HasColumnType("int");

                    b.Property<string>("PdName")
                        .HasColumnName("Pd_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillId");

                    b.HasIndex("CusId");

                    b.HasIndex("PdId");

                    b.ToTable("TbBill");
                });

            modelBuilder.Entity("Shopping.Models.db.TbCart", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnName("Cart_ID")
                        .HasColumnType("int");

                    b.Property<byte[]>("CartImg")
                        .HasColumnName("Cart_Img")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("CartName")
                        .HasColumnName("Cart_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("CartPrice")
                        .HasColumnName("Cart_Price")
                        .HasColumnType("float");

                    b.Property<int?>("CartQty")
                        .HasColumnName("Cart_Qty")
                        .HasColumnType("int");

                    b.Property<double?>("CartTotal")
                        .HasColumnName("Cart_Total")
                        .HasColumnType("float");

                    b.HasKey("CartId");

                    b.ToTable("TbCart");
                });

            modelBuilder.Entity("Shopping.Models.db.TbCategory", b =>
                {
                    b.Property<int>("CateId")
                        .HasColumnName("Cate_ID")
                        .HasColumnType("int");

                    b.Property<string>("CateName")
                        .HasColumnName("Cate_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CateId");

                    b.ToTable("TbCategory");
                });

            modelBuilder.Entity("Shopping.Models.db.TbCustomer", b =>
                {
                    b.Property<int>("CusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Cus_ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CusAddress")
                        .HasColumnName("Cus_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CusEmail")
                        .HasColumnName("Cus_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CusName")
                        .HasColumnName("Cus_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CusPhone")
                        .HasColumnName("Cus_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("CusReceipt")
                        .HasColumnName("Cus_Receipt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("CusId");

                    b.ToTable("TbCustomer");
                });

            modelBuilder.Entity("Shopping.Models.db.TbProduct", b =>
                {
                    b.Property<int>("PdId")
                        .HasColumnName("Pd_ID")
                        .HasColumnType("int");

                    b.Property<int?>("CateId")
                        .HasColumnName("Cate_ID")
                        .HasColumnType("int");

                    b.Property<int?>("PdDelete")
                        .HasColumnName("Pd_Delete")
                        .HasColumnType("int");

                    b.Property<string>("PdDetail")
                        .HasColumnName("Pd_Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PdImg")
                        .HasColumnName("Pd_Img")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PdName")
                        .HasColumnName("Pd_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PdPrice")
                        .HasColumnName("Pd_Price")
                        .HasColumnType("float");

                    b.Property<string>("PdStatus")
                        .HasColumnName("Pd_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PdStock")
                        .HasColumnName("Pd_Stock")
                        .HasColumnType("int");

                    b.Property<string>("PdSubHead")
                        .HasColumnName("Pd_SubHead")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PdId")
                        .HasName("PK_Tb_Product");

                    b.HasIndex("CateId");

                    b.ToTable("TbProduct");
                });

            modelBuilder.Entity("Shopping.Models.db.TbReview", b =>
                {
                    b.Property<int>("RevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Rev_ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PdName")
                        .HasColumnName("Pd_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime?>("RevDate")
                        .HasColumnName("Rev_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("RevMessage")
                        .HasColumnName("Rev_Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RevTitle")
                        .HasColumnName("Rev_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RevId");

                    b.ToTable("TbReview");
                });

            modelBuilder.Entity("Shopping.Models.db.TbBill", b =>
                {
                    b.HasOne("Shopping.Models.db.TbCustomer", "Cus")
                        .WithMany("TbBill")
                        .HasForeignKey("CusId")
                        .HasConstraintName("FK_TbBill_TbCustomer");

                    b.HasOne("Shopping.Models.db.TbProduct", "Pd")
                        .WithMany("TbBill")
                        .HasForeignKey("PdId")
                        .HasConstraintName("FK_TbBill_TbProduct");
                });

            modelBuilder.Entity("Shopping.Models.db.TbProduct", b =>
                {
                    b.HasOne("Shopping.Models.db.TbCategory", "Cate")
                        .WithMany("TbProduct")
                        .HasForeignKey("CateId")
                        .HasConstraintName("FK_TbProduct_TbCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
