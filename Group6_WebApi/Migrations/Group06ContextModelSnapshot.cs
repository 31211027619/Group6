﻿// <auto-generated />
using System;
using Group6_WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Group6_WebApi.Migrations
{
    [DbContext(typeof(Group06Context))]
    partial class Group06ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Group6_WebApi.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("account_id");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("company_id");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int")
                        .HasColumnName("tenant_id");

                    b.Property<string>("Username")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("username");

                    b.HasKey("AccountId")
                        .HasName("PK__Account__46A222CD442DB334");

                    b.HasIndex("CompanyId");

                    b.HasIndex("TenantId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("company_id");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("address");

                    b.Property<string>("ContactInfo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("contact_info");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int")
                        .HasColumnName("tenant_id");

                    b.HasKey("CompanyId")
                        .HasName("PK__Company__3E26723594932133");

                    b.HasIndex("TenantId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Group6_WebApi.Models.DetailInvoice", b =>
                {
                    b.Property<int>("DetailId")
                        .HasColumnType("int")
                        .HasColumnName("detail_id");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int")
                        .HasColumnName("invoice_id");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("Note")
                        .HasColumnType("text")
                        .HasColumnName("note");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("price");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int?>("TaxId")
                        .HasColumnType("int")
                        .HasColumnName("tax_id");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("total_amount");

                    b.HasKey("DetailId")
                        .HasName("PK__Detail_I__38E9A22406349550");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TaxId");

                    b.ToTable("Detail_Invoice");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .HasColumnType("int")
                        .HasColumnName("invoice_id");

                    b.Property<DateTime?>("InvoiceDate")
                        .HasColumnType("datetime")
                        .HasColumnName("invoice_date");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int")
                        .HasColumnName("tenant_id");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("total_amount");

                    b.HasKey("InvoiceId")
                        .HasName("PK__Invoice__F58DFD49129FC0A3");

                    b.HasIndex("TenantId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("price");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int")
                        .HasColumnName("tenant_id");

                    b.HasKey("ProductId")
                        .HasName("PK__Product__47027DF5F3E7F9EC");

                    b.HasIndex("TenantId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Tax", b =>
                {
                    b.Property<int>("TaxId")
                        .HasColumnType("int")
                        .HasColumnName("tax_id");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<decimal?>("Rate")
                        .HasColumnType("decimal(5, 2)")
                        .HasColumnName("rate");

                    b.HasKey("TaxId")
                        .HasName("PK__Tax__129B8670C0BA286F");

                    b.ToTable("Tax");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Tenant", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("int")
                        .HasColumnName("tenant_id");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("address");

                    b.Property<string>("ContactInfo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("contact_info");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.HasKey("TenantId")
                        .HasName("PK__Tenant__D6F29F3E1CBCA3CD");

                    b.ToTable("Tenant");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Account", b =>
                {
                    b.HasOne("Group6_WebApi.Models.Company", "Company")
                        .WithMany("Accounts")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK__Account__company__4F7CD00D");

                    b.HasOne("Group6_WebApi.Models.Tenant", "Tenant")
                        .WithMany("Accounts")
                        .HasForeignKey("TenantId")
                        .HasConstraintName("FK__Account__tenant___4E88ABD4");

                    b.Navigation("Company");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Company", b =>
                {
                    b.HasOne("Group6_WebApi.Models.Tenant", "Tenant")
                        .WithMany("Companies")
                        .HasForeignKey("TenantId")
                        .HasConstraintName("FK__Company__tenant___4BAC3F29");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Group6_WebApi.Models.DetailInvoice", b =>
                {
                    b.HasOne("Group6_WebApi.Models.Invoice", "Invoice")
                        .WithMany("DetailInvoices")
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("FK__Detail_In__invoi__59FA5E80");

                    b.HasOne("Group6_WebApi.Models.Product", "Product")
                        .WithMany("DetailInvoices")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__Detail_In__produ__5AEE82B9");

                    b.HasOne("Group6_WebApi.Models.Tax", "Tax")
                        .WithMany("DetailInvoices")
                        .HasForeignKey("TaxId")
                        .HasConstraintName("FK__Detail_In__tax_i__5BE2A6F2");

                    b.Navigation("Invoice");

                    b.Navigation("Product");

                    b.Navigation("Tax");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Invoice", b =>
                {
                    b.HasOne("Group6_WebApi.Models.Tenant", "Tenant")
                        .WithMany("Invoices")
                        .HasForeignKey("TenantId")
                        .HasConstraintName("FK__Invoice__tenant___5535A963");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Product", b =>
                {
                    b.HasOne("Group6_WebApi.Models.Tenant", "Tenant")
                        .WithMany("Products")
                        .HasForeignKey("TenantId")
                        .HasConstraintName("FK__Product__tenant___52593CB8");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Company", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Invoice", b =>
                {
                    b.Navigation("DetailInvoices");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Product", b =>
                {
                    b.Navigation("DetailInvoices");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Tax", b =>
                {
                    b.Navigation("DetailInvoices");
                });

            modelBuilder.Entity("Group6_WebApi.Models.Tenant", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Companies");

                    b.Navigation("Invoices");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
